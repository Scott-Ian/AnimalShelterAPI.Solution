namespace AnimalShelterAPI.Models
{
  public class PaginationFilter
  {
    public int PageNumber { get; }
    public int PageSize { get; }

    public PaginationFilter()
    {
      this.PageNumber = 1;
      this.PageSize = 10;
    }

    public PaginationFilter(int pageNumber, int pageSize)
    {
      if(pageSize > 50)
      {
        pageSize = 50;
      } else if (pageSize <= 0)
      {
        pageSize = 10;
      }
      
      this.PageNumber = pageNumber;
      this.PageSize = pageSize;
    }
  }
}