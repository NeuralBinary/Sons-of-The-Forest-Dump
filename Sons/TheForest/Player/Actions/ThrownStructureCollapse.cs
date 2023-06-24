using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Crafting.Structures;
using UnityEngine;

namespace TheForest.Player.Actions
{
	// Token: 0x0200048B RID: 1163
	[Token(Token = "0x200048B")]
	[AddComponentMenu("Sons/Construction/Screw/ThrownStructureCollapse")]
	public class ThrownStructureCollapse : MonoBehaviour
	{
		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x000088F8 File Offset: 0x00006AF8
		// (set) Token: 0x06001E2D RID: 7725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000421")]
		private static int EventPathId
		{
			[Token(Token = "0x6001E2C")]
			[Address(RVA = "0x32EDFA0", Offset = "0x32EC5A0", VA = "0x1832EDFA0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E2D")]
			[Address(RVA = "0x32EDFF0", Offset = "0x32EC5F0", VA = "0x1832EDFF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E2E")]
		[Address(RVA = "0x32EE050", Offset = "0x32EC650", VA = "0x1832EE050")]
		public static void Throw(StructureRecipe recipe, Vector3 pos, Quaternion rot, Vector3 forward)
		{
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E2F")]
		[Address(RVA = "0x32EE5E0", Offset = "0x32ECBE0", VA = "0x1832EE5E0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E30")]
		[Address(RVA = "0x32EE7B0", Offset = "0x32ECDB0", VA = "0x1832EE7B0")]
		private void PlaySfx()
		{
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00008910 File Offset: 0x00006B10
		[Token(Token = "0x6001E31")]
		[Address(RVA = "0x32EEA90", Offset = "0x32ED090", VA = "0x1832EEA90")]
		private bool TryFindEventMpId(string path)
		{
			return default(bool);
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E32")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ThrownStructureCollapse()
		{
		}

		// Token: 0x04001C56 RID: 7254
		[Token(Token = "0x4001C56")]
		private const string BreakSfx = "event:/SotF Events/player sounds/Build Sounds/build_break_apart";

		// Token: 0x04001C57 RID: 7255
		[Token(Token = "0x4001C57")]
		[FieldOffset(Offset = "0x20")]
		private StructureCraftingNode _node;
	}
}
