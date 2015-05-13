##1  医生信息查询


|相关信息|内容|
|--|--|
|访问类型|POST|
|访问地址|/api/doctor/DoctorInfo|

###请求参数

|参数名称|是否必填|类型|说明|示例数据|
|--|--|--|--|--|--|
|user_id|是|字符串|用户ID||
|token|是|字符串|token||


###请求示例
<pre>
<code>
{
     "token": "4feb7168-69a6-4afa-8da4-818ee204ed33",
       "user_id": "533ACADF-2C72-41CF-BCCE-CB2DF1A1EB38"
}
</code>
</pre>

###返回结果示例

<pre>
<code>


    {
       "code": 1,
       "message": "",
       "result_data":
       {
           "name": "",
           "avatar": "",
           "doctor_id": "100230",
           "sex": 0,
           "province": "",
           "hospital": "",
           "title": "",
           "introduce":""
       }
    }




</code>
</pre>

##2 通过ID查询医生信息
|相关信息|内容|
|--|--|
|访问类型|POST|
|访问地址|/api/patient/QueryDoctorInfoByID|

###请求参数

|参数名称|是否必填|类型|说明|示例数据|
|--|--|--|--|--|--|
|user_id|是|字符串|用户ID||
|token|是|字符串|token||
|doctor_id|是|字符串|医生ID|

###请求示例
<pre>
<code>
{
     "token": "4feb7168-69a6-4afa-8da4-818ee204ed33",
       "user_id": "533ACADF-2C72-41CF-BCCE-CB2DF1A1EB38",
       "doctor_id":"100010"
}
</code>
</pre>

###返回结果示例

<pre>
<code>


    {
       "code": 1,
       "message": "",
       "result_data":
       {
           "name": "",
           "avatar": "",
           "doctor_id": "100230",
           "sex": 0,
           "province": "",
           "hospital": "",
           "title": "",
           "introduce":""
       }
    }




</code>
</pre>






