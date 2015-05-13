### 基本说明

基本API路由协议：/api/{controller}/{action}/{id}

###数据统一返回格式

WEB API默认调用接口返回统一格式内容，如下：

|属性|类型|说明|
|--|--|--|
|code|整形|结果类型 0 失败，1 成功，2 token过期|
|message|字符串|结果消息|
|result_data|JSON对象|结果数据|

###接口访问说明

WEB API的访问会根据HEADER请求参数来返回需要返回的相关请求内容(json或者XML)，如果想要返回参数为JSON格式，请设置HEADER信息如下：

|类型|值|
|--|--|
|Accept|application/json|
|Content-Type|application/json|



