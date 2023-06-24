using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Obi;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Physics
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	public class TearRopeCallback : MonoBehaviour
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public event Action OnRopeTorn
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x3107B40", Offset = "0x3106140", VA = "0x183107B40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x3107C30", Offset = "0x3106230", VA = "0x183107C30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x3107D20", Offset = "0x3106320", VA = "0x183107D20")]
		private void OnEnable()
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x3107E70", Offset = "0x3106470", VA = "0x183107E70")]
		private void OnDisable()
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x3107FC0", Offset = "0x31065C0", VA = "0x183107FC0")]
		private void RopeTornCallback(ObiRope rope, ObiRope.ObiRopeTornEventArgs tearinfo)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TearRopeCallback()
		{
		}

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ObiRope _rope;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent _onRopeTornUnityEvent;
	}
}
