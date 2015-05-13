# 病历修改
|相关信息|内容|
|--|--|
|访问类型|POST|
|访问地址|/api/MedicalHis/UpdateMedicalHisDetail|
###请求参数

|参数名称|是否必填|类型|说明|示例数据|
|--|--|--|--|--|--|
|user_id|是|字符串|用户ID||
|token|是|字符串|token||
|patient_id|是|字符串|病人ID||
|SickNess|是|字符串|所患疾病||

###请求示例
<pre>
<code>
{
        "token": "8e6da47d-ec7c-4994-8540-6f32bb163b68",
       "user_id": "EE81E3DA-92F0-4AA2-B410-7B643D9B5307",
        "detailgid":"4f390f4a-fac7-4c8d-82f8-38be0b482edf",
        "hisgid":"",
        "title":"标题"，
        "descript":"描述",
        "lstPic":
        [{"imgdata":"图片二进制字符串"}
        {"imgdata":"图片二进制字符串"}]

}
</code>
</pre>


###返回结果示例

<pre>
<code>


    {
       "code": 1,
       "message": "更新病历成功",
       "result_data":null

    }



</code>
</pre>