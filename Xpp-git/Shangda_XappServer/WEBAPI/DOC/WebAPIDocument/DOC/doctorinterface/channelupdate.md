# 频道更新
|相关信息|内容|
|--|--|
|访问类型|POST|
|访问地址|/api/Channel/ChannelUpdate|
###请求参数

|参数名称|是否必填|类型|说明|示例数据|
|--|--|--|--|--|--|
|user_id|是|字符串|用户ID||
|token|是|字符串|token||
|ChannelName|是|字符串|频道名称||
|ChannelGid|是|字符串|频道GID||

###请求示例
<pre>
<code>
{
        "token": "8e6da47d-ec7c-4994-8540-6f32bb163b68",
       "user_id": "EE81E3DA-92F0-4AA2-B410-7B643D9B5307",
        "ChannelName":"频道名称",
        "ChannelGid":"频道GID"
}
</code>
</pre>


###返回结果示例

<pre>
<code>
    {
       "code": 1,
       "message": "更新成功",
       "result_data":null

    }
</code>
</pre>
