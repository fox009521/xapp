# 修改我的患者信息

|相关信息|内容|
|--|--|
|访问类型|POST|
|访问地址|/api/doctor/EditMyPatientInfo|
###请求参数

|参数名称|是否必填|类型|说明|示例数据|
|--|--|--|--|--|--|
|user_id|是|字符串|用户ID||
|token|是|字符串|token||
|patientId|是|字符串|患者id|
|bedNum|否|字符串|床号|
|admissionTime|否|datetime|入院时间|
|diagnosisResult|否|字符串|诊断情况|
|patientStatus|否|数字|患者状态|123 分别为  门诊 住院  出院  4为删除
|recoveryPlan|否|字符串|方案ID|如果删除康复方案传一个cancel即可



###请求示例
<pre>
<code>
{
    "token": "65b45c29-4164-471f-bc78-1ace1cc58ee6",
    "user_id": "7A161693-CC5B-4632-8AA7-96320C6DFA95",
    "patientId": "D4ABF6B6-C495-4BCF-AAEA-CA435F7853A8",
    "bedNum": "1111111",
    "admissionTime": "2015-03-13 13:45:59",
    "diagnosisResult": "",
    "recoveryPlan": "",
    "patientStatus": ""
}
</code>
</pre>


###返回结果示例

<pre>
<code>



    {
       "code": 1,
       "message": "患者修改成功",
       "result_data": null
    }



</code>
</pre>









