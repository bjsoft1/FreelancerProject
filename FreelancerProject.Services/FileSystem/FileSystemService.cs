using FreelancerProject.Dto;
using Microsoft.AspNetCore.Http;

namespace FreelancerProject.Services.FileSystem
{
    public interface IFileSystemService : IBaseAppService
    {
        Task<FileCreateUpdateDto> UploadFile(IFormFile file);
        Task<List<FileCreateUpdateDto>> UploadFiles(List<IFormFile> files);
    }
    public class FileSystemService : BaseAppService, IFileSystemService
    {
        //TODO: File Add,Update, Delete, Get 

        public async Task<FileCreateUpdateDto> UploadFile(IFormFile file)
        {
            //TODO:
            return await Task.FromResult(new FileCreateUpdateDto
            {
                FileURL = "assets/images/products/19.png",
            });
        }

        public async Task<List<FileCreateUpdateDto>> UploadFiles(List<IFormFile> files)
        {
            //TODO:
            return await Task.FromResult(new List<FileCreateUpdateDto>
            {
                new FileCreateUpdateDto
                {
                    FileURL = "assets/images/products/14.png",
                }
            });
        }
    }
}
