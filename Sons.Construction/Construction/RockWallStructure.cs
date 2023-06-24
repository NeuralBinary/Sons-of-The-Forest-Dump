using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000253 RID: 595
	[Token(Token = "0x2000253")]
	[AddComponentMenu("Sons/Construction/RockWallStructure")]
	public class RockWallStructure : WallStructure, IRockStructure, IStructure, IMonoBehaviour, ISuperStructureNode, ITargetablePlacement
	{
		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x0000AE14 File Offset: 0x00009014
		[Token(Token = "0x17000415")]
		public override ushort TypeID
		{
			[Token(Token = "0x6001207")]
			[Address(RVA = "0x2F31D30", Offset = "0x2F30330", VA = "0x182F31D30", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000416")]
		public new static Counter Counter
		{
			[Token(Token = "0x6001208")]
			[Address(RVA = "0x2F31D40", Offset = "0x2F30340", VA = "0x182F31D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0000AE2C File Offset: 0x0000902C
		[Token(Token = "0x6001209")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600120A")]
		[Address(RVA = "0x2F31D90", Offset = "0x2F30390", VA = "0x182F31D90", Slot = "131")]
		private StructureElement GetElementPlacementInfo(StructureElement linePrefab, int lineNum, out Vector3 worldPos, out Quaternion worldRot, out float zScale, Vector3 nearPos)
		{
			return null;
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x0000AE44 File Offset: 0x00009044
		[Token(Token = "0x600120B")]
		[Address(RVA = "0x2F31E40", Offset = "0x2F30440", VA = "0x182F31E40", Slot = "132")]
		private Vector3 CalcTemplateOffset(StructureElement elementInstance)
		{
			return default(Vector3);
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x0000AE5C File Offset: 0x0000905C
		[Token(Token = "0x600120C")]
		[Address(RVA = "0x2F31F00", Offset = "0x2F30500", VA = "0x182F31F00", Slot = "69")]
		public override bool IsCompleted()
		{
			return default(bool);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600120D")]
		[Address(RVA = "0x2EC04F0", Offset = "0x2EBEAF0", VA = "0x182EC04F0", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600120E")]
		[Address(RVA = "0x2E86000", Offset = "0x2E84600", VA = "0x182E86000", Slot = "79")]
		public override StructureElement AddElement(StructureElement elementPrefab, Vector3 worldPos)
		{
			return null;
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x0000AE74 File Offset: 0x00009074
		[Token(Token = "0x600120F")]
		[Address(RVA = "0x2E86A50", Offset = "0x2E85050", VA = "0x182E86A50", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x0000AE8C File Offset: 0x0000908C
		[Token(Token = "0x6001210")]
		[Address(RVA = "0x2F31F20", Offset = "0x2F30520", VA = "0x182F31F20", Slot = "74")]
		public override Vector3 CalcElementPosition(StructureElement elementPrefab, int elementIndex)
		{
			return default(Vector3);
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x0000AEA4 File Offset: 0x000090A4
		[Token(Token = "0x6001211")]
		[Address(RVA = "0x2F31FA0", Offset = "0x2F305A0", VA = "0x182F31FA0", Slot = "83")]
		public override bool TryRemoveElement(Vector3 nearPos, out ElementProfile elementProfile)
		{
			return default(bool);
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001212")]
		[Address(RVA = "0x2E872B0", Offset = "0x2E858B0", VA = "0x182E872B0", Slot = "86")]
		public override void ApplyRepair(float healthAlpha)
		{
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001213")]
		[Address(RVA = "0x2F32120", Offset = "0x2F30720", VA = "0x182F32120", Slot = "134")]
		private void CalcClosestElementPlacement(StructureElement elementPrefab, Vector3 worldPos, int skip, out Vector3 position, out Quaternion rotation, out float lengthScale)
		{
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0000AEBC File Offset: 0x000090BC
		[Token(Token = "0x6001214")]
		[Address(RVA = "0x2EC0820", Offset = "0x2EBEE20", VA = "0x182EC0820", Slot = "130")]
		public override int GetFullLineCount()
		{
			return 0;
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001215")]
		[Address(RVA = "0x2F32160", Offset = "0x2F30760", VA = "0x182F32160")]
		public RockWallStructure()
		{
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001217")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001218")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001219")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0000AED4 File Offset: 0x000090D4
		[Token(Token = "0x600121A")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}
	}
}
