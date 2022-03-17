namespace ToDoList.Models
{
  public class CategoryItemTag
    {       
        // Notice that CategoryId and TagId have the ? operator that 
        // makes them nullable types, meaning they can have a value
        // of null, which is not allowed otherwise. This allows us
        // to use one join table to track two separate many-to-many
        // relationships: between Items and Tags, and Items and 
        // Categories. On any given entry into our join table, either
        // CategoryId or TagId will not have a value, meaning it will
        // be left as "null". This is why we need to declare
        // CategoryId and TagId as nullable. 
        public int CategoryItemTagId { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public int? TagId { get; set; }
        public Tag Tag { get; set; }
    }
}