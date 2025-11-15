## Return Results

### Result

```CSharp
//200 OK
return Results.Ok();
//201 CREATED
return Results.Created();
//202 ACCEPTED
return Results.Accepted();
//204 NO CONTENT
return Results.NoContent();
//400 BAD REQUEST
return Results.BadRequest();
//401 UNAUTHORIZED
return Results.Unauthorized();
//403 FORBIDDEN
return Results.Forbid();
//404 NOT FOUND
return Results.NotFound();
//409 CONFLICT
return Results.Conflict();
```

### Typed Result

```CSharp
//200 OK
return TypedResults.Ok();
//201 CREATED
return TypedResults.Created();
//202 ACCEPTED
return TypedResults.Accepted();
//204 NO CONTENT
return TypedResults.NoContent();
//204 NO CONTENT
return TypedResults.InternalServerError();
```
