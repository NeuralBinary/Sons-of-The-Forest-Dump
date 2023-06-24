using System;
using Construction;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	[CreateAssetMenu(menuName = "Sons/Construction/GRABS/VisualInstanceProvider", fileName = "VisualInstanceProvider - XX")]
	public class VisualInstanceProvider : ScriptableObject, IVisualInstanceProvider, IVisualDashInstanceProvider, IVisualInteractionPointInstanceProvider, IVisualLogInstanceProvider
	{
		// Token: 0x060002BC RID: 700 RVA: 0x00002EAC File Offset: 0x000010AC
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x2DB5930", Offset = "0x2DB3F30", VA = "0x182DB5930", Slot = "4")]
		private float GetDashLength()
		{
			return 0f;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x2DB5960", Offset = "0x2DB3F60", VA = "0x182DB5960", Slot = "5")]
		private Material GetDashMaterial(VisualModes mode)
		{
			return null;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x2DB5A10", Offset = "0x2DB4010", VA = "0x182DB5A10", Slot = "6")]
		private DashVisual SpawnDash(VisualModes mode, Vector3 pos, Quaternion rotation, Transform parent)
		{
			return null;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2DB5AD0", Offset = "0x2DB40D0", VA = "0x182DB5AD0", Slot = "7")]
		private void Despawn(DashVisual instance)
		{
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x2DB5B70", Offset = "0x2DB4170", VA = "0x182DB5B70", Slot = "8")]
		private VisualFader SpawnInteractionDot(Vector3 pos, Quaternion rotation, Transform parent)
		{
			return null;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x2DB5C30", Offset = "0x2DB4230", VA = "0x182DB5C30", Slot = "9")]
		private void Despawn(VisualFader instance)
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002EC4 File Offset: 0x000010C4
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x2DB5CD0", Offset = "0x2DB42D0", VA = "0x182DB5CD0", Slot = "10")]
		private Vector3 GetLogSize()
		{
			return default(Vector3);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002EDC File Offset: 0x000010DC
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x2DB5D00", Offset = "0x2DB4300", VA = "0x182DB5D00", Slot = "11")]
		public float ConvertLogScale(ElementProfile sourceElement, float scale)
		{
			return 0f;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x2DB5D60", Offset = "0x2DB4360", VA = "0x182DB5D60", Slot = "12")]
		private GameObject SpawnLog(Vector3 pos, Quaternion rotation, Transform parent)
		{
			return null;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x2DB5E70", Offset = "0x2DB4470", VA = "0x182DB5E70", Slot = "13")]
		private void DespawnLog(GameObject logInstance)
		{
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x2DB5EC0", Offset = "0x2DB44C0", VA = "0x182DB5EC0", Slot = "14")]
		private GameObject SpawnLogPlank(Vector3 pos, Quaternion rotation, Transform parent)
		{
			return null;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x2DB5FD0", Offset = "0x2DB45D0", VA = "0x182DB5FD0", Slot = "15")]
		private void DespawnLogPlank(GameObject logPlankInstance)
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public VisualInstanceProvider()
		{
		}

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DashVisual _dashPrefab;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DashVisual _dashPreviewPrefab;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VisualFader _interactionDotPrefab;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private StructureElement _logPrefab;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private StructureElement _logPlankPrefab;
	}
}
