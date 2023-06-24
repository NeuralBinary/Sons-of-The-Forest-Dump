using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Pathfinding.Examples
{
	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	[RequireComponent(typeof(Animator))]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_hexagon_trigger.php")]
	public class HexagonTrigger : MonoBehaviour
	{
		// Token: 0x06000B92 RID: 2962 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x64C950", Offset = "0x64AF50", VA = "0x18064C950")]
		private void Awake()
		{
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x64CA00", Offset = "0x64B000", VA = "0x18064CA00")]
		private void OnTriggerEnter(Collider coll)
		{
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x64CCE0", Offset = "0x64B2E0", VA = "0x18064CCE0")]
		private void OnTriggerExit(Collider coll)
		{
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public HexagonTrigger()
		{
		}

		// Token: 0x0400085A RID: 2138
		[Token(Token = "0x400085A")]
		[FieldOffset(Offset = "0x20")]
		public Button button;

		// Token: 0x0400085B RID: 2139
		[Token(Token = "0x400085B")]
		[FieldOffset(Offset = "0x28")]
		private Animator anim;

		// Token: 0x0400085C RID: 2140
		[Token(Token = "0x400085C")]
		[FieldOffset(Offset = "0x30")]
		private bool visible;
	}
}
