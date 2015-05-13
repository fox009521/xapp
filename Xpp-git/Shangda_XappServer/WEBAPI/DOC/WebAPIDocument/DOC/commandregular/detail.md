## 病历查询
|相关信息|内容|
|--|--|
|访问类型|POST|
|访问地址|/api/MedicalHis/MedicalHisDetailInfo|

###请求参数

|参数名称|是否必填|类型|说明|示例数据|
|--|--|--|--|--|--|
|user_id|是|字符串|用户ID||
|token|是|字符串|token||
|hisgid|是|字符串|病历夹ID||


###请求示例
<pre>
<code>
{
     "token": "4feb7168-69a6-4afa-8da4-818ee204ed33",
     "user_id": "533ACADF-2C72-41CF-BCCE-CB2DF1A1EB38",
     "hisgid":"4f390f4a-fac7-4c8d-82f8-38be0b482edf"
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
           "Id": "张三",
           "DetailGid": 1,
           "HisID": 23,
           "DetailTitle": "4f390f4a-fac7-4c8d-82f8-38be0b482edf",
           "DetailDescribe": "EDC8F6C4-C112-441C-9D20-EBEA6284EDC9",
           "CreateUser": "6A228D59-0A42-416D-A173-1F38C30979E9",
           "CreateTime":"2015-03-18T16:49:09",
           "UpdateTime": "2015-03-18T16:49:09",
           "Status": 1，
           "PicList"
           [{
            "Id":"",
            "PicGid":"",
            "DetailGid":"",
            "PicUrl":"",
            "CreateUser": "6A228D59-0A42-416D-A173-1F38C30979E9",
           "CreateTime":"2015-03-18T16:49:09",
           "UpdateTime": "2015-03-18T16:49:09",
           "Status": 1
           }]
       }
    }




</code>
</pre>

