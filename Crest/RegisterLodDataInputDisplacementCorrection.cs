using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	[ExecuteAlways]
	public abstract class RegisterLodDataInputDisplacementCorrection<LodDataType> : RegisterLodDataInput<LodDataType> where LodDataType : LodDataMgr
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x1700006B")]
		protected override bool FollowHorizontalMotion
		{
			[Token(Token = "0x60001D1")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D2")]
		protected RegisterLodDataInputDisplacementCorrection()
		{
		}

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x0")]
		[Tooltip("Whether this input data should displace horizontally with waves. If false, data will not move from side to side with the waves. Adds a small performance overhead when disabled.")]
		[SerializeField]
		private bool _followHorizontalMotion;
	}
}
