#### [DefaultEcs](./index.md 'index')
### [DefaultEcs](./DefaultEcs.md 'DefaultEcs').[Entity](./DefaultEcs-Entity.md 'DefaultEcs.Entity')
## Entity.RemoveFromChildrenOf(DefaultEcs.Entity) Method
Remove the given [Entity](./DefaultEcs-Entity.md 'DefaultEcs.Entity') from current [Entity](./DefaultEcs-Entity.md 'DefaultEcs.Entity') parents.  
```csharp
public void RemoveFromChildrenOf(in DefaultEcs.Entity parent);
```
#### Parameters
<a name='DefaultEcs-Entity-RemoveFromChildrenOf(DefaultEcs-Entity)-parent'></a>
`parent` [Entity](./DefaultEcs-Entity.md 'DefaultEcs.Entity')  
The [Entity](./DefaultEcs-Entity.md 'DefaultEcs.Entity') which acts as parent.  
  
#### Exceptions
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
[Entity](./DefaultEcs-Entity.md 'DefaultEcs.Entity') was not created from a [World](./DefaultEcs-World.md 'DefaultEcs.World').  
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Child and parent [Entity](./DefaultEcs-Entity.md 'DefaultEcs.Entity') come from a different [World](./DefaultEcs-World.md 'DefaultEcs.World').  
