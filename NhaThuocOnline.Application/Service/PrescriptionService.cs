using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NhaThuocOnline.Application.Interface;
using NhaThuocOnline.Data.EF;
using NhaThuocOnline.Data.Entities;
using NhaThuocOnline.ViewModel.Category;
using NhaThuocOnline.ViewModel.Prescription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Application.Service
{
    public class PrescriptionService : IPrescriptionService
    {
        private readonly NhaThuocOnlineDbContext _dbContext;
        private const string USER_CONTENT_FOLDER_NAME = "user-content";
        private readonly IFileStorageService _storageService;
        public PrescriptionService(NhaThuocOnlineDbContext dbContext, IFileStorageService storageService)
        {
            _dbContext = dbContext;
            _storageService = storageService;
        }
        public async Task<bool> Create(PrescriptionCreateRequest request)
        {
            var imagePath = "/img/prescriptions/default.jpg";
            if (request.ImagePath != null)
            {

                imagePath = await this.SaveFile(request.ImagePath);
            }
            var newPrescription = new Prescription() {
                CustomerName = request.CustomerName,
                CustomerNote = request.CustomerNote,
                CustomerPhone = request.CustomerPhone,
                ImagePath = imagePath,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            _dbContext.Prescriptions.Add(newPrescription);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<PrescriptionVm>> GetAll()
        {
            var data = await _dbContext.Prescriptions.Select(x => new PrescriptionVm
            {
                Id = x.Id,
                CustomerName = x.CustomerName,
                CustomerNote = x.CustomerNote,
                CustomerPhone = x.CustomerPhone,
                ImagePath = x.ImagePath,
                CreatedDate = x.CreatedDate
            }).OrderByDescending(x=>x.CreatedDate).ToListAsync();

            return new List<PrescriptionVm>(data);
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"prescription{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}
