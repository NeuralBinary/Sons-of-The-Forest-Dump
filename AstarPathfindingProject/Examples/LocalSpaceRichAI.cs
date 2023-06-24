using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Examples
{
	// Token: 0x02000173 RID: 371
	[Token(Token = "0x2000173")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_local_space_rich_a_i.php")]
	public class LocalSpaceRichAI : RichAI
	{
		// Token: 0x06000B8A RID: 2954 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x64C690", Offset = "0x64AC90", VA = "0x18064C690")]
		private void RefreshTransform()
		{
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x64C7A0", Offset = "0x64ADA0", VA = "0x18064C7A0", Slot = "24")]
		protected override void Start()
		{
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x64C7D0", Offset = "0x64ADD0", VA = "0x18064C7D0", Slot = "31")]
		protected override void CalculatePathRequestEndpoints(out Vector3 start, out Vector3 end)
		{
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x64C8E0", Offset = "0x64AEE0", VA = "0x18064C8E0", Slot = "27")]
		protected override void Update()
		{
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x64C900", Offset = "0x64AF00", VA = "0x18064C900")]
		public LocalSpaceRichAI()
		{
		}

		// Token: 0x04000858 RID: 2136
		[Token(Token = "0x4000858")]
		[FieldOffset(Offset = "0x190")]
		public LocalSpaceGraph graph;
	}
}
