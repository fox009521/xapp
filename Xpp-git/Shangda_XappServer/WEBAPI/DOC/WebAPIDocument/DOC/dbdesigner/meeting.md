# T_meeting学术活动表
<td bgcolor="#F5F9FF">
    <table cellspacing="0" cellpadding="5" border="1" width="100%" bordercolorlight="#D7D7E5" bordercolordark="#D3D8E0">
         <tbody>
          <tr bgcolor="#F0F0F0">
           <td>序号</td>
           <td>列名</td>
           <td>数据类型</td>
           <td>长度</td>
           <td>小数位</td>
           <td>标识</td>
           <td>主键</td>
           <td>外键</td>
           <td>允许空</td>
           <td>默认值</td>
           <td>说明</td>
          </tr>
          <tr>
           <td>1</td>
           <td>Meeting_ID</td>
           <td>int</td>
           <td>4</td>
           <td>0</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>否</td>
           <td>&nbsp;</td>
           <td align="left">活动ID</td>
          </tr>
          <tr>
           <td>2</td>
           <td>Meeting_GID</td>
           <td>nvarchar</td>
           <td>40</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>newid</td>
           <td align="left">活动标识</td>
          </tr>
          <tr>
           <td>3</td>
           <td>Meeting_Title</td>
           <td>nvarchar</td>
           <td>100</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">活动名称</td>
          </tr>
          <tr>
           <td>4</td>
           <td>Meeting_Time</td>
           <td>datetime</td>
           <td>8</td>
           <td>3</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">活动时间</td>
          </tr>
          <tr>
           <td>5</td>
           <td>Meeting_Pos</td>
           <td>nvarchar</td>
           <td>200</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">活动地点</td>
          </tr>
          <tr>
           <td>6</td>
           <td>Meeting_Caller</td>
           <td>nvarchar</td>
           <td>64</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">发起人</td>
          </tr>
          <tr>
           <td>7</td>
           <td>Meeting_Describe</td>
           <td>nvarchar</td>
           <td>500</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">活动描述</td>
          </tr>
          <tr>
           <td>8</td>
           <td>Meeting_Creater</td>
           <td>nvarchar</td>
           <td>40</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">创建人（医生ID）</td>
          </tr>
          <tr>
           <td>9</td>
           <td>isDel</td>
           <td>int</td>
           <td>4</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>1</td>
           <td align="left">是否取消/活动状态（1-有效/0-取消）</td>
          </tr>
          <tr>
           <td>10</td>
           <td>CreateTime</td>
           <td>datetime</td>
           <td>8</td>
           <td>3</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>getdate</td>
           <td align="left">创建时间</td>
          </tr>
          <tr>
           <td>11</td>
           <td>UpdateTime</td>
           <td>datetime</td>
           <td>8</td>
           <td>3</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>getdate</td>
           <td align="left">更新时间</td>
          </tr>
          <tr>
           <td>12</td>
           <td>status</td>
           <td>int</td>
           <td>4</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>1</td>
           <td align="left">记录状态（1-有效/0-无效）</td>
          </tr>
         </tbody>
        </table>
</td>

# 建表语句
<pre>
<code>
--学术活动表
CREATE TABLE T_MEETING
(
	Meeting_ID INT IDENTITY(1,1),--活动ID
	Meeting_GID nvarchar(40) default newid(),--活动标识
	Meeting_Title nvarchar(100),--活动名称
	Meeting_Time datetime,--活动时间
	Meeting_Pos nvarchar(200),--活动地点
	Meeting_Caller nvarchar(64),--发起人
	Meeting_Describe nvarchar(500),--活动描述
	Meeting_Creater nvarchar(40),--创建人（医生ID）
	isDel int default 1,--是否取消/活动状态（1-有效/0-取消）
	CreateTime datetime default getdate(),--创建时间
	UpdateTime datetime default getdate(),--更新时间
	status int default 1	--记录状态（1-有效/0-无效）
)
</code>
</pre>
