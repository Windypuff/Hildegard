﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Htest.Models;
using System.IO;
using Microsoft.AspNetCore.Http;
using OfficeOpenXml;
using Htest.Data;

namespace Htest.Controllers
{
    public class TeacherController : Controller
    {
        string teacherName = @"Adrian Blacker";
        string className = @"7RED/Ar";
        public IActionResult Index()
        {
            var helper = new ExcelHelper();
            var teachers = helper.GetAllTeachers();
            List<HClass> classes = helper.GetAllClassesForTeacher(teacherName);
            List<Student> students = helper.GetStudentsForClass(className);
            return View(classes);
        }       

                [HttpGet]
        public IActionResult Upload(string id="")
        {
             ViewBag.Success = TempData["success"];
            // if (!String.IsNullOrEmpty(id)) {
            //     ViewBag.Success = "success";
            // }

            return View((Object)id);
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile xlsfile)
        {
            var fileName = xlsfile.FileName;
            if (System.IO.File.Exists(fileName)) {
                //System.IO.File.Delete(fileName);
            }
            System.IO.File.Delete("test.xlsx");
            using (FileStream output = System.IO.File.Create("text.xlsx"))
            {
                await xlsfile.CopyToAsync(output);
            }
            var cmd=@"xlsxparser.py";
            var args = "\"" + fileName + "\"";
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "python.exe ";
            start.Arguments = string.Format("{0} {1}", cmd, args);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            Process.Start(start);
            // using(Process process = Process.Start(start))
            // {
            //     using(StreamReader reader = process.StandardOutput)
            //     {
            //         string result = reader.ReadToEnd();
            //         Console.Write(result);
            //     }
            // }
            // ViewBag.Success = "success";    
            return View();
  
        }


        public class HookData {
            public string status {get; set;}
        }
        [HttpPost]
        public IActionResult UploadHook(string name)
        {
            // ViewBag.Success = "Success";
            // TempData["success"] = "success";
            //return RedirectToAction("Upload", "Teacher", new {id=name});
            //return View("/Home/Index");
            return Ok();
        }  
    }
}
