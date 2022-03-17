## Many-To-Many-To-Many with To Do List

This application shows how to create a many-to-many-to-many relationship, where one class (`Item`) is in two separate many-to-many relationships (with `Tag` and `Category`): Items and Tags, and Items and Categories.

This application uses one join table to track the two many-to-many relationships. It's not necessary to do it. You can have a separate join table for each many-to-many relationship. To use just one join table to track multiple many-to-many relationships, you need to use nullable types. See the comment in `Models/CategoryItemTag.cs` that explains this. 

Using nullable types disrupts the normal function of "cascade delete" for many-to-many relationships, which handles deleting the join relationship (category-item) when we delete an associated object (item). If you want to review what cascade delete is, [review this lesson on LHTP](https://www.learnhowtoprogram.com/c-and-net/many-to-many-relationships/many-to-many-delete-functionality). Otherwise note that the `DeleteConfirmed` route in the `CategoriesController.cs` and `TagsController.cs` files have been updated! There's a comment in each that explains why.