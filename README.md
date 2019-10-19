## Usage

```
public class UsersData
{
  [CompositeKey]    
  public Guid UserId{ get; set; }

  [CompositeKey]
  [Required]
  public string DataId { get; set; }
}
```

```
public class MyDbContext : DbContext
{
  ...  
  protected override void OnModelCreating(DbModelBuilder modelBuilder)
  {
    ...
    modelBuilder.BindCompositeKey();
  }  
}
```
