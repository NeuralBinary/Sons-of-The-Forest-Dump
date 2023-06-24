using System;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	[Serializable]
	public class CustomObjectParameter<T> : VolumeParameter<T>
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00005370 File Offset: 0x00003570
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public sealed override bool overrideState
		{
			[Token(Token = "0x60003E5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E6")]
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x00004DB2 File Offset: 0x00002FB2
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public sealed override T value
		{
			[Token(Token = "0x60003E7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E8")]
			set
			{
			}
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E9")]
		public CustomObjectParameter(T value)
		{
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EA")]
		public override void Interp(T from, T to, float t)
		{
		}

		// Token: 0x040004DB RID: 1243
		[Token(Token = "0x40004DB")]
		private const string kEnabledParameter = "enabled";
	}
}
