using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Assemblies.Sons.VFX
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	[AddComponentMenu("Sons/VFX/MossDistribution")]
	public class MossDistribution : MonoBehaviour
	{
		// Token: 0x0600011A RID: 282 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x5F1D10", Offset = "0x5F0310", VA = "0x1805F1D10")]
		public float GetFactor()
		{
			return 0f;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x317C9C0", Offset = "0x317AFC0", VA = "0x18317C9C0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x317C9C0", Offset = "0x317AFC0", VA = "0x18317C9C0")]
		private void ConvertTargetToList()
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x317CAF0", Offset = "0x317B0F0", VA = "0x18317CAF0")]
		public void Setup(IEnumerable<Renderer> renderables, float factor, bool shouldActivate = true)
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x317CB10", Offset = "0x317B110", VA = "0x18317CB10")]
		public void Setup(Renderer renderable, float factor, bool shouldActivate = true)
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x317CB30", Offset = "0x317B130", VA = "0x18317CB30")]
		public void Setup(List<Renderer> renderables, MapDistributionData distribution)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x317CBA0", Offset = "0x317B1A0", VA = "0x18317CBA0")]
		public void Setup(Renderer renderable, MapDistributionData distribution)
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x317CC10", Offset = "0x317B210", VA = "0x18317CC10")]
		private void AddTargets(IEnumerable<Renderer> renderables, bool skipRefresh = false)
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x317CDE0", Offset = "0x317B3E0", VA = "0x18317CDE0")]
		private void AddTarget(Renderer renderable, bool skipRefresh = false)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x317CFA0", Offset = "0x317B5A0", VA = "0x18317CFA0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x317CFB0", Offset = "0x317B5B0", VA = "0x18317CFB0")]
		private void Refresh()
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x317D1C0", Offset = "0x317B7C0", VA = "0x18317D1C0")]
		private void UpdateFactor()
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x317D380", Offset = "0x317B980", VA = "0x18317D380")]
		private void ApplyFactor(float factor)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x317D540", Offset = "0x317BB40", VA = "0x18317D540")]
		public static void ApplyFactor(Material matInst, float factor)
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x317D690", Offset = "0x317BC90", VA = "0x18317D690")]
		private void SetupMaterialInstances()
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x317D870", Offset = "0x317BE70", VA = "0x18317D870")]
		private void SetupTargetMaterialInstances(Renderer target)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x317DC50", Offset = "0x317C250", VA = "0x18317DC50")]
		public MossDistribution()
		{
		}

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		private const string AddMossStringId = "_AddMoss";

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _forceAlways;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private Renderer _target;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Renderer> _targets;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _useDistribution;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MapDistributionData _distribution;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _shouldActivate;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _factor;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x50")]
		private List<Material> _materialInstances;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x58")]
		private List<Renderer> _appliedTargets;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int AddMossId;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int MossAmountId;
	}
}
