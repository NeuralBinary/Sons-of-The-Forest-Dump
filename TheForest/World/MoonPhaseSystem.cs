using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.World
{
	// Token: 0x02000395 RID: 917
	[Token(Token = "0x2000395")]
	public class MoonPhaseSystem : MonoBehaviour
	{
		// Token: 0x060017DF RID: 6111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017DF")]
		[Address(RVA = "0x2CD10A0", Offset = "0x2CD00A0", VA = "0x182CD10A0")]
		private void Start()
		{
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E0")]
		[Address(RVA = "0x2CD1110", Offset = "0x2CD0110", VA = "0x182CD1110")]
		private void Update()
		{
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E1")]
		[Address(RVA = "0x2CD0F10", Offset = "0x2CCFF10", VA = "0x182CD0F10")]
		private void RefreshMoonPhase()
		{
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E2")]
		[Address(RVA = "0x2CD11C0", Offset = "0x2CD01C0", VA = "0x182CD11C0")]
		public MoonPhaseSystem()
		{
		}

		// Token: 0x040016FE RID: 5886
		[Token(Token = "0x40016FE")]
		[FieldOffset(Offset = "0x20")]
		public Material _moonMat;

		// Token: 0x040016FF RID: 5887
		[Token(Token = "0x40016FF")]
		[FieldOffset(Offset = "0x28")]
		public Renderer _moonRenderer;

		// Token: 0x04001700 RID: 5888
		[Token(Token = "0x4001700")]
		[FieldOffset(Offset = "0x30")]
		public int _dayOffset;

		// Token: 0x04001701 RID: 5889
		[Token(Token = "0x4001701")]
		[FieldOffset(Offset = "0x34")]
		private int _lastUpdateDay;

		// Token: 0x04001702 RID: 5890
		[Token(Token = "0x4001702")]
		[FieldOffset(Offset = "0x38")]
		private MaterialPropertyBlock _moonPropertyBlock;
	}
}
