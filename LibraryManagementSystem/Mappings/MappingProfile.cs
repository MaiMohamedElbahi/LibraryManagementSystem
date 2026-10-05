using AutoMapper;
using LibraryManagementSystem.DTOs.BookDTO;
using LibraryManagementSystem.DTOs.BorrowingDTO;
using LibraryManagementSystem.DTOs.CategoryDTO;
using LibraryManagementSystem.DTOs.MemberDTO;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<UpdateBookDTO, Book>().ReverseMap();
            CreateMap<PartiallyUpdateBookDTO, Book>().ReverseMap();
            CreateMap<CreateBookDTO, Book>().ReverseMap();

            CreateMap<UpdateCategoryDTO, Category>().ReverseMap();
            CreateMap<PartiallyUpdateCategoryDTO, Category>().ReverseMap();
            CreateMap<CreateCategoryDTO, Category>().ReverseMap();

            CreateMap<UpdateBorrowingDTO, Borrowing>().ReverseMap();
            CreateMap<PartiallyUpdateBorrowingDTO, Borrowing>().ReverseMap();
            CreateMap<CreateBorrowingDTO, Borrowing>().ReverseMap();

            CreateMap<UpdateMemberDTO, Member>().ReverseMap();
            CreateMap<PartiallyUpdateMemberDTO, Member>().ReverseMap();
            CreateMap<CreateMemberDTO, Member>().ReverseMap();
        }
    }
}
