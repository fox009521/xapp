# 频道内容查询
|相关信息|内容|
|--|--|
|访问类型|POST|
|访问地址|/api/Channel/ChannelContentInfo|

###请求参数

|参数名称|是否必填|类型|说明|示例数据|
|--|--|--|--|--|--|
|user_id|是|字符串|用户ID||
|token|是|字符串|token||
|ChannelGid|是|字符串|频道GID||


###请求示例
<pre>
<code>
{
     "token": "249550bd-8407-4417-867c-aa43e2fd45b1",
     "user_id": "B44AF41F-D3B9-463E-944B-D955891D576E"，
     "ChannelGid":"频道GID"
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
           "CCGid": "频道内容GID",
           "CCChannelGid":"所属频道GID"
           "CCContent": "内容",
           "CCPicUrl": "图片URL（多个URL用逗号隔开）",
           "CCReplyCount":"回复个数",
           "CCAgreeCount":"点赞个数",
           "CCCreater":"创建人GID",
           "CCCreaterName":"创建人姓名",
           "CreateTime":"2015-03-18T16:49:09",
           "UpdateTime": "2015-03-18T16:49:09",
           "Status": 1
       }
    }




</code>
</pre>
