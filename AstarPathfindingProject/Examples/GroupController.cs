using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.RVO;
using UnityEngine;

namespace Pathfinding.Examples
{
	// Token: 0x02000165 RID: 357
	[Token(Token = "0x2000165")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_group_controller.php")]
	public class GroupController : MonoBehaviour
	{
		// Token: 0x06000B47 RID: 2887 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x72C650", Offset = "0x72AC50", VA = "0x18072C650")]
		public void Start()
		{
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x72C8A0", Offset = "0x72AEA0", VA = "0x18072C8A0")]
		public void Update()
		{
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x72CE50", Offset = "0x72B450", VA = "0x18072CE50")]
		private void OnGUI()
		{
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x72D290", Offset = "0x72B890", VA = "0x18072D290")]
		public void Order()
		{
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x72D830", Offset = "0x72BE30", VA = "0x18072D830")]
		public void Select(Vector2 _start, Vector2 _end)
		{
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00006D34 File Offset: 0x00004F34
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x72DCC0", Offset = "0x72C2C0", VA = "0x18072DCC0")]
		public Color GetColor(float angle)
		{
			return default(Color);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x72DD10", Offset = "0x72C310", VA = "0x18072DD10")]
		public GroupController()
		{
		}

		// Token: 0x040007E8 RID: 2024
		[Token(Token = "0x40007E8")]
		[FieldOffset(Offset = "0x20")]
		public GUIStyle selectionBox;

		// Token: 0x040007E9 RID: 2025
		[Token(Token = "0x40007E9")]
		[FieldOffset(Offset = "0x28")]
		public bool adjustCamera;

		// Token: 0x040007EA RID: 2026
		[Token(Token = "0x40007EA")]
		[FieldOffset(Offset = "0x2C")]
		private Vector2 start;

		// Token: 0x040007EB RID: 2027
		[Token(Token = "0x40007EB")]
		[FieldOffset(Offset = "0x34")]
		private Vector2 end;

		// Token: 0x040007EC RID: 2028
		[Token(Token = "0x40007EC")]
		[FieldOffset(Offset = "0x3C")]
		private bool wasDown;

		// Token: 0x040007ED RID: 2029
		[Token(Token = "0x40007ED")]
		[FieldOffset(Offset = "0x40")]
		private List<RVOExampleAgent> selection;

		// Token: 0x040007EE RID: 2030
		[Token(Token = "0x40007EE")]
		[FieldOffset(Offset = "0x48")]
		private Simulator sim;

		// Token: 0x040007EF RID: 2031
		[Token(Token = "0x40007EF")]
		[FieldOffset(Offset = "0x50")]
		private Camera cam;

		// Token: 0x040007F0 RID: 2032
		[Token(Token = "0x40007F0")]
		private const float rad2Deg = 57.295776f;
	}
}
