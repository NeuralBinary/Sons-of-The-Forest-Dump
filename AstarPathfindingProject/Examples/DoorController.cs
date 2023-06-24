using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Examples
{
	// Token: 0x02000183 RID: 387
	[Token(Token = "0x2000183")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_door_controller.php")]
	public class DoorController : MonoBehaviour
	{
		// Token: 0x06000BDB RID: 3035 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x6550E0", Offset = "0x6536E0", VA = "0x1806550E0")]
		public void Start()
		{
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x6551B0", Offset = "0x6537B0", VA = "0x1806551B0")]
		private void OnGUI()
		{
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x655270", Offset = "0x653870", VA = "0x180655270")]
		public void SetState(bool open)
		{
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x655430", Offset = "0x653A30", VA = "0x180655430")]
		public DoorController()
		{
		}

		// Token: 0x040008B1 RID: 2225
		[Token(Token = "0x40008B1")]
		[FieldOffset(Offset = "0x20")]
		private bool open;

		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x40008B2")]
		[FieldOffset(Offset = "0x24")]
		public int opentag;

		// Token: 0x040008B3 RID: 2227
		[Token(Token = "0x40008B3")]
		[FieldOffset(Offset = "0x28")]
		public int closedtag;

		// Token: 0x040008B4 RID: 2228
		[Token(Token = "0x40008B4")]
		[FieldOffset(Offset = "0x2C")]
		public bool updateGraphsWithGUO;

		// Token: 0x040008B5 RID: 2229
		[Token(Token = "0x40008B5")]
		[FieldOffset(Offset = "0x30")]
		public float yOffset;

		// Token: 0x040008B6 RID: 2230
		[Token(Token = "0x40008B6")]
		[FieldOffset(Offset = "0x34")]
		private Bounds bounds;
	}
}
