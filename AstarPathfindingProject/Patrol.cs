using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_patrol.php")]
	[UniqueComponent(tag = "ai.destination")]
	public class Patrol : VersionedMonoBehaviour
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x61B8C0", Offset = "0x619EC0", VA = "0x18061B8C0", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x61B960", Offset = "0x619F60", VA = "0x18061B960")]
		private void Update()
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x61BBD0", Offset = "0x61A1D0", VA = "0x18061BBD0")]
		public Patrol()
		{
		}

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x28")]
		public Transform[] targets;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x30")]
		public float delay;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x34")]
		private int index;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x38")]
		private IAstarAI agent;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x40")]
		private float switchTime;
	}
}
