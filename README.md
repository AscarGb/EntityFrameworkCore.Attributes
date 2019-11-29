# EntityFrameworkCore.Attributes
Entity framework core composite primary key attribute

[![NuGet](https://img.shields.io/badge/nuget-1.0.1-blue)](https://www.nuget.org/packages/EntityFrameworkCore.Attributes/)

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
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    ...
    modelBuilder.BindCompositeKey();
  }  
}
```
