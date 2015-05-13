# 审批患者报到
|相关信息|内容|
|--|--|
|访问类型|POST|
|访问地址|/api/doctor/ReportApproval|

###请求参数

|参数名称|是否必填|类型|说明|示例数据|
|--|--|--|--|--|--|
|user_id|是|字符串|用户ID||
|token|是|字符串|token||
|patientId|是|字符串|患者ID||
|reporResult|是|字符串|审批结果|0为默认状态 Default=0,Approve=1,Reject=2
|bedNum|否|字符串|床位号||
|admissionTime|否|datetime|入院时间||
|diagnosisResult|否|datetime|诊断结果||
|recoveryPlan|否|字符串|康复方案||


###请求示例
<pre>
<code>
{
"token":"76ffb08e-f09d-48d7-9a4c-787c99418aa5",
"user_id":"EE81E3DA-92F0-4AA2-B410-7B643D9B5307",
  "patientId":"138096E0-1DE1-450D-8283-E8763603E26C",
  "reporResult":"1",
  "redNum":"10010",
  "admissionTime":"2015-3-12",
  "diagnosisResult":"1",
  "recoveryPlan":"1"
}
</code>
</pre>

###返回结果示例

<pre>
<code>

{"code":1,"message":"审批成功","result_data":null}

</code>
</pre>
