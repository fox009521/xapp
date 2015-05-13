# T_Meeting_Focus学术活动关注详情表
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
           <td>id</td>
           <td>int</td>
           <td>4</td>
           <td>0</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>否</td>
           <td>&nbsp;</td>
           <td align="left">详情ID</td>
          </tr>
          <tr>
           <td>2</td>
           <td>Focus_GID</td>
           <td>nvarchar</td>
           <td>40</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>newid</td>
           <td align="left">详情标识</td>
          </tr>
          <tr>
           <td>3</td>
           <td>Meeting_ID</td>
           <td>int</td>
           <td>4</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">会议ID</td>
          </tr>
          <tr>
           <td>4</td>
           <td>Focus_User</td>
           <td>nvarchar</td>
           <td>64</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>否</td>
           <td>&nbsp;</td>
           <td align="left">关注人（医生ID）</td>
          </tr>
          <tr>
           <td>5</td>
           <td>Focus_Time</td>
           <td>datetime</td>
           <td>8</td>
           <td>3</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">关注时间</td>
          </tr>
          <tr>
           <td>6</td>
           <td>UpdateTime</td>
           <td>datetime</td>
           <td>8</td>
           <td>3</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">更新时间</td>
          </tr>
          <tr>
           <td>7</td>
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
#建表语句
<pre>
<code>
--学术活动关注详情表
CREATE TABLE T_Meeting_Focus
(
	id int identity(1,1),--详情ID
	Focus_GID NVARCHAR(40) DEFAULT NEWID(),--详情标识
	Meeting_ID int,--会议ID
	Focus_User nvarchar(64) not null,--关注人（医生ID）
	Focus_Time datetime,--关注时间
	UpdateTime datetime, --更新时间
	status int default 1 --记录状态（1-有效/0-无效）
)
</code>
</pre>
