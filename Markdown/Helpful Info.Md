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

### The API request lifecycle

![alt text](images/image.png)

Taken from the point a client makes a request, to the point a response is received:

1. **The request is parsed** – On receipt of the request, ASP.NET takes the incoming data and extracts critical information, such as the HTTP method in use (GET, POST, PUT, etc.). The URL is extracted, along with the request’s headers and body.

2. **The middleware pipeline is executed** – Middleware sitting in the chain is processed, with each middleware component operating on the request as configured. For example, authentication middleware could check that the sender of the request is authenticated, custom middleware could alter the structure of the request, and logging middleware could reference the request in logs that it writes to various data sources.
3. **Routing** – Now that the application has parsed the request and processed it through any relevant middleware, it can match the extracted URL and HTTP method against the routes configured in the API. This allows the request’s content to be routed to the appropriate endpoint for handling. Routing is just another example of a middleware component. As such, its order of execution can be altered within the pipeline.
4. **Dependency injection** – Once the request has been routed to the correct request, the dependency injection container will resolve any dependencies required to process the request and inject them into the components containing the endpoint, making them available during processing.
5. **Request handling** – The request is effectively now inside the endpoint, as in, it is being processed by the logic a developer has written inside the body of a minimal API endpoint they have written. Parameters passed in can be used within the endpoint body to process the required logic.
6. **Response generation** – Once the logic defined within the body of the endpoint has finished executing (or if an exception is thrown), a response will be generated. The response contains any expected data for the HTTP method on the endpoint, such as JSON or a simple string. It also has a status code appropriate to the processing result, for example,** 200 OK, 400 Bad Request**, or **500 Internal Server Error**. Once generated, the response is sent back to the client, and the HTTP conversation is over.
