# 医生信息更新


|相关信息|内容|
|--|--|
|访问类型|POST|
|访问地址|/api/doctor/UpdateDoctorInfo|

###请求参数

|参数名称|是否必填|类型|说明|示例数据|
|--|--|--|--|--|--|
|user_id|是|字符串|用户ID||
|token|是|字符串|token||
|name|否|字符串|姓名||
|city|否|字符串|城市||
|province|否|字符串|省||
|hospital|否|字符串|医院||
|title|否|字符串|职称||
|introduce|否|字符串|个性签名||
|sex|否|整形|性别，0男，1女||



###请求示例
<pre>
<code>
{
     "token": "4feb7168-69a6-4afa-8da4-818ee204ed33",
       "user_id": "533ACADF-2C72-41CF-BCCE-CB2DF1A1EB38",
"name":"jack",
"city":"quanzhou",
"province":"fujian",
"hospital":"nice hostpital",
"title":"senior",
"sex":1

}
</code>
</pre>

###返回结果示例

<pre>
<code>


    {
       "code": 1,
       "message": "更新成功",
       "result_data": null
    }



</code>
</pre>



