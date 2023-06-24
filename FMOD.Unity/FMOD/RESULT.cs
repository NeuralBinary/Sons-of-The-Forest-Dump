using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public enum RESULT
	{
		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		OK,
		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		ERR_BADCOMMAND,
		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		ERR_CHANNEL_ALLOC,
		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		ERR_CHANNEL_STOLEN,
		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		ERR_DMA,
		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		ERR_DSP_CONNECTION,
		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		ERR_DSP_DONTPROCESS,
		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		ERR_DSP_FORMAT,
		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		ERR_DSP_INUSE,
		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		ERR_DSP_NOTFOUND,
		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		ERR_DSP_RESERVED,
		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		ERR_DSP_SILENCE,
		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		ERR_DSP_TYPE,
		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		ERR_FILE_BAD,
		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		ERR_FILE_COULDNOTSEEK,
		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		ERR_FILE_DISKEJECTED,
		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		ERR_FILE_EOF,
		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		ERR_FILE_ENDOFDATA,
		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		ERR_FILE_NOTFOUND,
		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		ERR_FORMAT,
		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		ERR_HEADER_MISMATCH,
		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		ERR_HTTP,
		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		ERR_HTTP_ACCESS,
		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		ERR_HTTP_PROXY_AUTH,
		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		ERR_HTTP_SERVER_ERROR,
		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		ERR_HTTP_TIMEOUT,
		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		ERR_INITIALIZATION,
		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		ERR_INITIALIZED,
		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		ERR_INTERNAL,
		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		ERR_INVALID_FLOAT,
		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		ERR_INVALID_HANDLE,
		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		ERR_INVALID_PARAM,
		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		ERR_INVALID_POSITION,
		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		ERR_INVALID_SPEAKER,
		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		ERR_INVALID_SYNCPOINT,
		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		ERR_INVALID_THREAD,
		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		ERR_INVALID_VECTOR,
		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		ERR_MAXAUDIBLE,
		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		ERR_MEMORY,
		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		ERR_MEMORY_CANTPOINT,
		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		ERR_NEEDS3D,
		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		ERR_NEEDSHARDWARE,
		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		ERR_NET_CONNECT,
		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		ERR_NET_SOCKET_ERROR,
		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		ERR_NET_URL,
		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		ERR_NET_WOULD_BLOCK,
		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		ERR_NOTREADY,
		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		ERR_OUTPUT_ALLOCATED,
		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		ERR_OUTPUT_CREATEBUFFER,
		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		ERR_OUTPUT_DRIVERCALL,
		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		ERR_OUTPUT_FORMAT,
		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		ERR_OUTPUT_INIT,
		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		ERR_OUTPUT_NODRIVERS,
		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		ERR_PLUGIN,
		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		ERR_PLUGIN_MISSING,
		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		ERR_PLUGIN_RESOURCE,
		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		ERR_PLUGIN_VERSION,
		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		ERR_RECORD,
		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		ERR_REVERB_CHANNELGROUP,
		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		ERR_REVERB_INSTANCE,
		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		ERR_SUBSOUNDS,
		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		ERR_SUBSOUND_ALLOCATED,
		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		ERR_SUBSOUND_CANTMOVE,
		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		ERR_TAGNOTFOUND,
		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		ERR_TOOMANYCHANNELS,
		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		ERR_TRUNCATED,
		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		ERR_UNIMPLEMENTED,
		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		ERR_UNINITIALIZED,
		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		ERR_UNSUPPORTED,
		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		ERR_VERSION,
		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		ERR_EVENT_ALREADY_LOADED,
		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		ERR_EVENT_LIVEUPDATE_BUSY,
		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		ERR_EVENT_LIVEUPDATE_MISMATCH,
		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		ERR_EVENT_LIVEUPDATE_TIMEOUT,
		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		ERR_EVENT_NOTFOUND,
		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		ERR_STUDIO_UNINITIALIZED,
		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		ERR_STUDIO_NOT_LOADED,
		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		ERR_INVALID_STRING,
		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		ERR_ALREADY_LOCKED,
		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		ERR_NOT_LOCKED,
		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		ERR_RECORD_DISCONNECTED,
		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		ERR_TOOMANYSAMPLES
	}
}
