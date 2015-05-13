# 内容回复删除
|相关信息|内容|
|--|--|
|访问类型|POST|
|访问地址|/api/Channel/ChannelContentReplyDelete|

###请求参数

|参数名称|是否必填|类型|说明|示例数据|
|--|--|--|--|--|--|
|user_id|是|字符串|用户ID||
|token|是|字符串|token||
|ReplyGid|是|字符串|回复GID||


###请求示例
<pre>
<code>
{
     "token": "249550bd-8407-4417-867c-aa43e2fd45b1",
     "user_id": "B44AF41F-D3B9-463E-944B-D955891D576E",
     "ReplyGid":"回复GID"
}
</code>
</pre>

###返回结果示例

<pre>
<code>


    {
       "code": 1,
       "message": "删除成功",
       "result_data":null

    }




</code>
</pre>
