# 我的患者列表
|相关信息|内容|
|--|--|
|访问类型|POST|
|访问地址|/api/doctor/MyPatients|

###请求参数

|参数名称|是否必填|类型|说明|示例数据|
|--|--|--|--|--|--|
|user_id|是|字符串|用户ID||
|token|是|字符串|token||
|patientStatus|是|字符串|患者状态|  0123 分别为全部  门诊 住院  出院

###请求示例
<pre>
<code>
{
        "token": "8e6da47d-ec7c-4994-8540-6f32bb163b68",
       "user_id": "EE81E3DA-92F0-4AA2-B410-7B643D9B5307",
        "patientStatus":"0"

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
       [
           {
               "patientMId": "100013",
               "patientId": "D4ABF6B6-C495-4BCF-AAEA-CA435F7853A8",
               "sex": 0,
               "name": "贾建西",
               "avatar": "/UploadFiles/Avatars/b57b2d8e-d870-4cbf-b568-f7c019d14168.png",
               "age": 26,
               "patientType": 1,
               "diagnosisResult": null,
               "bedNum": null,
               "admissionTime": "2015-03-18T16:49:09",
               "recoveryPlan": "99f27407-190c-4822-b392-34b572a704dc",
               "templateName": "模版一"
           }
       ]
    }

备注
返回信息中
recoveryPlan 为模版ID
templateName 为模版名称




</code>
</pre>
