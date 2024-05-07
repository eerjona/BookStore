namespace BookStore.App.Services
{
    public interface IBookServices
    {
        List<Models.Book> GetAllBooks();
        Models.Book GetBookById(int id);
        //Models.Student AddStudent(PostStudentDto student);
        //Models.Student UpdateStudent(PutStudentDto studentData, int id);
        void DeleteBook(int id);
        
    }
}
