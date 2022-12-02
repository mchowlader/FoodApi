# Mitra Dinner Api

Table of contents(up to date)
- [Mitra Dinner Api](#mitra-dinner-api)
  - [Auth](#auth)
    - [Register](#register)
        - [Register Request](#register-request)
        - [Register Response](#register-response)
    - [Login](#login)
        - [Login Request](#login-request)
        - [Login Response](#login-response)



### Auth

### Register
```js
POST {{host}}/auth/register
```

### Register Request
```json
{
    "firstName" : "Mithun",
    "lastName" : "Howlader",
    "email" : "mithun.howlader222@gmail.com",
    "password" : "123456" 
}
```

### Register Response
```js
200 ok
{
    "firstName" : "Mithun",
    "lastName" : "Howlader",
    "email" : "mithun.howlader222@gmail.com",
}
```

### Login
```js
POST {{host}}/auth/login
```
### Login Request
```json
{
    "email" : "mithun.howlader222@gmail.com",
    "password" : "123456" 
}
```


### Login Response
```json
{
    "id" : "",
    "firstName" : "Mithun",
    "lastName" : "Howlader",
    "email" : "mithun.howlader222@gmail.com",
    "token" : "eyJhb..hbbQ" 
}
```