# Repository.Ef  
[![NuGet](https://img.shields.io/nuget/v/M.Repository.EntityFramework.svg)](https://www.nuget.org/packages/M.Repository.EntityFramework)  

An implementation of [M.Repository](https://github.com/petar-m/repository) abstraction using EntityFramework.  

## Setup  

- Inherit `Entity<TKey>` in order to use `IRepository<TEntity>`.
  
*example:*  
  
    public class Item : Entity<int>
    {
        public string InventoryNumber { get; set; }
        public int Quantity { get; set; }
    }
  
- Setup repositories and unit of work with concrete implementations.  

*example (pseudo code):*  
    
    For<IRepository<>>().Use<Repository<>>();
    For<IUnitOfWork>().Use<UnitOfWork>();  

- To use asynchronous queries setup `QueryableAsyncExtensionsProxy` with `EfQueryableAsyncExtensions`.  
  
*example:*  

    QueryableAsyncExtensionsProxy.Initialize(new EfQueryableAsyncExtensions()); 
