using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x02000679 RID: 1657
	[Token(Token = "0x2000679")]
	public class DetectCollisionBlocked : MonoBehaviour
	{
		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06002B6C RID: 11116 RVA: 0x0000CD50 File Offset: 0x0000AF50
		[Token(Token = "0x170005B7")]
		public bool IsBlocked
		{
			[Token(Token = "0x6002B6C")]
			[Address(RVA = "0x674880", Offset = "0x672E80", VA = "0x180674880")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6D")]
		[Address(RVA = "0x340E4D0", Offset = "0x340CAD0", VA = "0x18340E4D0")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6E")]
		[Address(RVA = "0x340E680", Offset = "0x340CC80", VA = "0x18340E680")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6F")]
		[Address(RVA = "0x340EB40", Offset = "0x340D140", VA = "0x18340EB40")]
		public DetectCollisionBlocked()
		{
		}

		// Token: 0x04002665 RID: 9829
		[Token(Token = "0x4002665")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _tagFilter;

		// Token: 0x04002666 RID: 9830
		[Token(Token = "0x4002666")]
		[FieldOffset(Offset = "0x28")]
		private List<Collider> _activeBlockers;

		// Token: 0x04002667 RID: 9831
		[Token(Token = "0x4002667")]
		[FieldOffset(Offset = "0x30")]
		private List<Collider> _inactiveBlockers;

		// Token: 0x04002668 RID: 9832
		[Token(Token = "0x4002668")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<Collider, int> _activeBlockersFrames;

		// Token: 0x04002669 RID: 9833
		[Token(Token = "0x4002669")]
		[FieldOffset(Offset = "0x40")]
		private bool _blocked;
	}
}
