using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Obi;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200023B RID: 571
	[Token(Token = "0x200023B")]
	[AddComponentMenu("Sons/Construction/TarpDeformationEffector")]
	public class TarpDeformationEffector : MonoBehaviour
	{
		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003F9")]
		public ObiSolver Solver
		{
			[Token(Token = "0x600114D")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003FA")]
		public ObiUpdater Updater
		{
			[Token(Token = "0x600114E")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003FB")]
		public TarpDeformationSystem.DeformationOperation Operation
		{
			[Token(Token = "0x600114F")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001150")]
			[Address(RVA = "0x661080", Offset = "0x65F680", VA = "0x180661080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001151")]
		[Address(RVA = "0x2F227C0", Offset = "0x2F20DC0", VA = "0x182F227C0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001152")]
		[Address(RVA = "0x2F22A00", Offset = "0x2F21000", VA = "0x182F22A00")]
		public void Init(TarpDeformationSystem.DeformationOperation operation)
		{
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001153")]
		[Address(RVA = "0x2F22F20", Offset = "0x2F21520", VA = "0x182F22F20")]
		public void ResetRenderer(TarpStructure tarp)
		{
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001154")]
		[Address(RVA = "0x2F23200", Offset = "0x2F21800", VA = "0x182F23200")]
		public void ActivateClothDeformation()
		{
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001155")]
		[Address(RVA = "0x2F232A0", Offset = "0x2F218A0", VA = "0x182F232A0")]
		public void StopClothDeformation()
		{
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001156")]
		[Address(RVA = "0x2F23380", Offset = "0x2F21980", VA = "0x182F23380")]
		private IEnumerator ClothDeformationRoutineFromSave()
		{
			return null;
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001157")]
		[Address(RVA = "0x2F23410", Offset = "0x2F21A10", VA = "0x182F23410")]
		private IEnumerator ClothDeformationRoutineAnimated()
		{
			return null;
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001158")]
		[Address(RVA = "0x2F234A0", Offset = "0x2F21AA0", VA = "0x182F234A0")]
		private IEnumerator ClothDeformationRoutineStepOn()
		{
			return null;
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001159")]
		[Address(RVA = "0x2F23530", Offset = "0x2F21B30", VA = "0x182F23530")]
		public void SetWobbling()
		{
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600115A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TarpDeformationEffector()
		{
		}

		// Token: 0x040008D3 RID: 2259
		[Token(Token = "0x40008D3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ObiSolver _solver;

		// Token: 0x040008D4 RID: 2260
		[Token(Token = "0x40008D4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ObiUpdater _updater;

		// Token: 0x040008D5 RID: 2261
		[Token(Token = "0x40008D5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ObiParticleAttachment[] _cornerAttachments;

		// Token: 0x040008D6 RID: 2262
		[Token(Token = "0x40008D6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MeshFilter _meshFilter;

		// Token: 0x040008D7 RID: 2263
		[Token(Token = "0x40008D7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _verbose;

		// Token: 0x040008D8 RID: 2264
		[Token(Token = "0x40008D8")]
		[FieldOffset(Offset = "0x48")]
		private TarpCornerAttachments _tarpCorners;

		// Token: 0x040008DA RID: 2266
		[Token(Token = "0x40008DA")]
		private const float LowDamping = 0.1f;

		// Token: 0x040008DB RID: 2267
		[Token(Token = "0x40008DB")]
		private const float HighDamping = 0.999f;
	}
}
