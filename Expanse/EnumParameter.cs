using System;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	[Serializable]
	public class EnumParameter<T> : VolumeParameter<T>
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00004DB2 File Offset: 0x00002FB2
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public override T value
		{
			[Token(Token = "0x60003EB")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003EC")]
			set
			{
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003ED")]
		public EnumParameter(T value, bool overrideState = false)
		{
		}
	}
}
