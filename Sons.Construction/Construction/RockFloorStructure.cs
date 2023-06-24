using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000191 RID: 401
	[Token(Token = "0x2000191")]
	[AddComponentMenu("Sons/Construction/RockFloorStructure")]
	public class RockFloorStructure : FloorStructure, IRockStructure, IStructure, IMonoBehaviour, ISuperStructureNode, ITargetablePlacement
	{
		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x00007DB4 File Offset: 0x00005FB4
		[Token(Token = "0x170002F1")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000C34")]
			[Address(RVA = "0x2EC0260", Offset = "0x2EBE860", VA = "0x182EC0260", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002F2")]
		public new static Counter Counter
		{
			[Token(Token = "0x6000C35")]
			[Address(RVA = "0x2EC0270", Offset = "0x2EBE870", VA = "0x182EC0270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00007DCC File Offset: 0x00005FCC
		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x2EC02C0", Offset = "0x2EBE8C0", VA = "0x182EC02C0", Slot = "128")]
		private StructureElement GetElementPlacementInfo(StructureElement linePrefab, int lineNum, out Vector3 worldPos, out Quaternion worldRot, out float zScale, Vector3 nearPos)
		{
			return null;
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00007DE4 File Offset: 0x00005FE4
		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x2EC0320", Offset = "0x2EBE920", VA = "0x182EC0320", Slot = "129")]
		private Vector3 CalcTemplateOffset(StructureElement elementInstance)
		{
			return default(Vector3);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00007DFC File Offset: 0x00005FFC
		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00", Slot = "70")]
		public override int CalcMaxElements()
		{
			return 0;
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00007E14 File Offset: 0x00006014
		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x2EC0430", Offset = "0x2EBEA30", VA = "0x182EC0430", Slot = "69")]
		public override bool IsCompleted()
		{
			return default(bool);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x2EC04F0", Offset = "0x2EBEAF0", VA = "0x182EC04F0", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x2EC04F0", Offset = "0x2EBEAF0", VA = "0x182EC04F0", Slot = "79")]
		public override StructureElement AddElement(StructureElement elementPrefab, Vector3 worldPos)
		{
			return null;
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00007E2C File Offset: 0x0000602C
		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x2E86A50", Offset = "0x2E85050", VA = "0x182E86A50", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00007E44 File Offset: 0x00006044
		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x2EC0520", Offset = "0x2EBEB20", VA = "0x182EC0520", Slot = "74")]
		public override Vector3 CalcElementPosition(StructureElement elementPrefab, int elementIndex)
		{
			return default(Vector3);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00007E5C File Offset: 0x0000605C
		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x2EC06A0", Offset = "0x2EBECA0", VA = "0x182EC06A0", Slot = "83")]
		public override bool TryRemoveElement(Vector3 nearPos, out ElementProfile elementProfile)
		{
			return default(bool);
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00007E74 File Offset: 0x00006074
		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x2EC0820", Offset = "0x2EBEE20", VA = "0x182EC0820", Slot = "126")]
		protected override int GetRepairableElements()
		{
			return 0;
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x2EC0830", Offset = "0x2EBEE30", VA = "0x182EC0830")]
		public RockFloorStructure()
		{
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00007E8C File Offset: 0x0000608C
		[Token(Token = "0x6000C46")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}
	}
}
