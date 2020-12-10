using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CompanyData;
using CompanyModel;
using CompanyServices;

namespace CompanyMVC.Controllers
{
    public class EmployeeTasksController : Controller
    {
        private readonly IEmployeeTaskServices _employeeTaskService;

        public EmployeeTasksController(IEmployeeTaskServices employeeTaskServices)
        {
            _employeeTaskService = employeeTaskServices;
        }

        // GET: EmployeeTasks
        public async Task<IActionResult> Index()
        {
            return View(await _employeeTaskService.GetAllEmpolyeeTask());
        }

        // GET: EmployeeTasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeTask = await _employeeTaskService.GetEmployeeTaskById(id);
            if (employeeTask == null)
            {
                return NotFound();
            }

            return View(employeeTask);
        }

        // GET: EmployeeTasks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeeTasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TaskName,StartDate,Deadline")] EmployeeTask employeeTask)
        {
            if (ModelState.IsValid)
            {
                await _employeeTaskService.CreateEmpolyeeTask(employeeTask);
                //await _empolyeeService.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeTask);
        }

        // GET: EmployeeTasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeTask = await _employeeTaskService.GetEmployeeTaskById(id);
            if (employeeTask == null)
            {
                return NotFound();
            }
            return View(employeeTask);
        }

        // POST: EmployeeTasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TaskName,StartDate,Deadline")] EmployeeTask employeeTask)
        {
            if (id != employeeTask.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _employeeTaskService.EditEmpolyeeTask(employeeTask);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (_employeeTaskService.GetEmployeeTaskById(employeeTask.Id) == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employeeTask);
        }

        // GET: EmployeeTasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeTask = await _employeeTaskService.GetEmployeeTaskById(id);
            if (employeeTask == null)
            {
                return NotFound();
            }

            return View(employeeTask);
        }

        // POST: EmployeeTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var empolyeeTask = await _employeeTaskService.GetEmployeeTaskById(id);
            await _employeeTaskService.DeleteEmpolyeeTask(empolyeeTask);
            return RedirectToAction(nameof(Index));
        }
    }
}
