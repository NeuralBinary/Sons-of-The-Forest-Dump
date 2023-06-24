using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Examples
{
	// Token: 0x02000176 RID: 374
	[Token(Token = "0x2000176")]
	[RequireComponent(typeof(Animator))]
	[RequireComponent(typeof(SingleNodeBlocker))]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_turn_based_door.php")]
	public class TurnBasedDoor : MonoBehaviour
	{
		// Token: 0x06000B96 RID: 2966 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x64CE30", Offset = "0x64B430", VA = "0x18064CE30")]
		private void Awake()
		{
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x64CF40", Offset = "0x64B540", VA = "0x18064CF40")]
		private void Start()
		{
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x64CFD0", Offset = "0x64B5D0", VA = "0x18064CFD0")]
		public void Close()
		{
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x64D070", Offset = "0x64B670", VA = "0x18064D070")]
		private IEnumerator WaitAndClose()
		{
			return null;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x64D100", Offset = "0x64B700", VA = "0x18064D100")]
		public void Open()
		{
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x64D1D0", Offset = "0x64B7D0", VA = "0x18064D1D0")]
		public void Toggle()
		{
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TurnBasedDoor()
		{
		}

		// Token: 0x0400085D RID: 2141
		[Token(Token = "0x400085D")]
		[FieldOffset(Offset = "0x20")]
		private Animator animator;

		// Token: 0x0400085E RID: 2142
		[Token(Token = "0x400085E")]
		[FieldOffset(Offset = "0x28")]
		private SingleNodeBlocker blocker;

		// Token: 0x0400085F RID: 2143
		[Token(Token = "0x400085F")]
		[FieldOffset(Offset = "0x30")]
		private bool open;
	}
}
