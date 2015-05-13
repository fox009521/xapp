# 点赞
|相关信息|内容|
|--|--|
|访问类型|POST|
|访问地址|/api/Channel/ChannelContentAgree|

###请求参数

|参数名称|是否必填|类型|说明|示例数据|
|--|--|--|--|--|--|
|user_id|是|字符串|用户ID||
|token|是|字符串|token||
|ContentGid|是|字符串|内容GID||


###请求示例
<pre>
<code>
{
     "token": "249550bd-8407-4417-867c-aa43e2fd45b1",
     "user_id": "B44AF41F-D3B9-463E-944B-D955891D576E",
     "ContentGid":"内容GID"
}
</code>
</pre>

###返回结果示例

<pre>
<code>


    {
       "code": 1,
       "message": "点赞成功",
       "result_data":null

    }




</code>
</pre>
