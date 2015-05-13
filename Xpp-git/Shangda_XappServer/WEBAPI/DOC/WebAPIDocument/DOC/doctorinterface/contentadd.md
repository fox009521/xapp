# 频道内容新增
|相关信息|内容|
|--|--|
|访问类型|POST|
|访问地址|/api/Channel/ChannelContentAdd|

###请求参数

|参数名称|是否必填|类型|说明|示例数据|
|--|--|--|--|--|--|
|user_id|是|字符串|用户ID||
|token|是|字符串|token||
|ChannelGID|是|字符串|频道GID||
|ChannelContent|是|字符串|发布的内容||
|lstPic|是|字符串|图片||
|？lstVedio|是|字符串|视频||


###请求示例
<pre>
<code>
{
     "token": "249550bd-8407-4417-867c-aa43e2fd45b1",
     "user_id": "B44AF41F-D3B9-463E-944B-D955891D576E",
     "ChannelGID":"频道GID",
     "ChannelContent":"内容",
     "lstPic":["图片二进制", "图片二进制"]
}
</code>
</pre>

###返回结果示例

<pre>
<code>


    {
       "code": 1,
       "message": "发布成功",
       "result_data":null

    }




</code>
</pre>
