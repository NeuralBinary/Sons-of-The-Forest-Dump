using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[AddComponentMenu("Sons/Ai/NavMeshCutBaker")]
	public class NavMeshCutBaker : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x17000001")]
		private bool IsStreams
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x2A947D0", Offset = "0x2A92DD0", VA = "0x182A947D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x17000002")]
		private bool IsLakes
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x2A947E0", Offset = "0x2A92DE0", VA = "0x182A947E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2A947F0", Offset = "0x2A92DF0", VA = "0x182A947F0")]
		private void CreateNavCutGameObject(out GameObject newGo, Transform matchTr, Transform parentTr, int count)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public NavMeshCutBaker()
		{
		}

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _sourceRoot;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _targetRoot;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private NavMeshCutBaker.BakeType _bakeType;

		// Token: 0x02000010 RID: 16
		[Token(Token = "0x2000010")]
		private enum BakeType
		{
			// Token: 0x04000026 RID: 38
			[Token(Token = "0x4000026")]
			Lakes,
			// Token: 0x04000027 RID: 39
			[Token(Token = "0x4000027")]
			Streams
		}
	}
}
