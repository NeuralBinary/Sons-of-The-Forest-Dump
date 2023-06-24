using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200023F RID: 575
	[Token(Token = "0x200023F")]
	[AddComponentMenu("Sons/Construction/TarpDeformationSystem")]
	public class TarpDeformationSystem : SingletonBehaviour<TarpDeformationSystem>
	{
		// Token: 0x0600116D RID: 4461 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600116D")]
		[Address(RVA = "0x2F23C40", Offset = "0x2F22240", VA = "0x182F23C40")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600116E")]
		[Address(RVA = "0x2F23CF0", Offset = "0x2F222F0", VA = "0x182F23CF0")]
		private void CheckTarpsPendingProximity()
		{
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0000A964 File Offset: 0x00008B64
		[Token(Token = "0x600116F")]
		[Address(RVA = "0x2F23F70", Offset = "0x2F22570", VA = "0x182F23F70")]
		private bool TryRegisterAsPendingProximity(TarpStructure tarp)
		{
			return default(bool);
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001170")]
		[Address(RVA = "0x2F240E0", Offset = "0x2F226E0", VA = "0x182F240E0")]
		public static void Register(TarpStructure tarp, DeformationMethods method)
		{
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001171")]
		[Address(RVA = "0x2F24320", Offset = "0x2F22920", VA = "0x182F24320")]
		public static void UnRegister(TarpStructure tarp, DeformationMethods method)
		{
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001172")]
		[Address(RVA = "0x2F24400", Offset = "0x2F22A00", VA = "0x182F24400")]
		public static void SetWobbling(TarpStructure tarp, DeformationMethods method)
		{
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x0000A97C File Offset: 0x00008B7C
		[Token(Token = "0x6001173")]
		[Address(RVA = "0x2F24490", Offset = "0x2F22A90", VA = "0x182F24490")]
		public static bool IsActivelyDeforming(TarpStructure tarp)
		{
			return default(bool);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001174")]
		[Address(RVA = "0x2F245F0", Offset = "0x2F22BF0", VA = "0x182F245F0")]
		private void CleanUpActivelyDeformingTarps()
		{
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001175")]
		[Address(RVA = "0x2F246B0", Offset = "0x2F22CB0", VA = "0x182F246B0")]
		public TarpDeformationSystem()
		{
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0000A994 File Offset: 0x00008B94
		[Token(Token = "0x6001176")]
		[Address(RVA = "0x2F24890", Offset = "0x2F22E90", VA = "0x182F24890")]
		[CompilerGenerated]
		private bool <TryRegisterAsPendingProximity>g__IsInProximity|8_0(out bool isTarpInCave, ref TarpDeformationSystem.<>c__DisplayClass8_0 A_2)
		{
			return default(bool);
		}

		// Token: 0x040008E8 RID: 2280
		[Token(Token = "0x40008E8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TarpDeformationSystem.DeformationSubSystem[] _subSystems;

		// Token: 0x040008E9 RID: 2281
		[Token(Token = "0x40008E9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _proximityMaxRange;

		// Token: 0x040008EA RID: 2282
		[Token(Token = "0x40008EA")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _verbose;

		// Token: 0x040008EB RID: 2283
		[Token(Token = "0x40008EB")]
		[FieldOffset(Offset = "0x38")]
		private List<TarpStructure> _activelyDeformingTarps;

		// Token: 0x040008EC RID: 2284
		[Token(Token = "0x40008EC")]
		[FieldOffset(Offset = "0x40")]
		private List<TarpStructure> _worldTarpsPendingProximity;

		// Token: 0x040008ED RID: 2285
		[Token(Token = "0x40008ED")]
		[FieldOffset(Offset = "0x48")]
		private List<TarpStructure> _cavesTarpsPendingProximity;

		// Token: 0x02000240 RID: 576
		[Token(Token = "0x2000240")]
		[Serializable]
		public class DeformationSubSystem
		{
			// Token: 0x06001177 RID: 4471 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001177")]
			[Address(RVA = "0x2F24C50", Offset = "0x2F23250", VA = "0x182F24C50")]
			public void TerminateFinishedOperations(List<TarpStructure> activelyDeformingTarps)
			{
			}

			// Token: 0x06001178 RID: 4472 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001178")]
			[Address(RVA = "0x2F24E90", Offset = "0x2F23490", VA = "0x182F24E90")]
			public void StartPendingOperations(List<TarpStructure> activelyDeformingTarps)
			{
			}

			// Token: 0x06001179 RID: 4473 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001179")]
			[Address(RVA = "0x2F250E0", Offset = "0x2F236E0", VA = "0x182F250E0")]
			public void Register(TarpDeformationSystem.DeformationOperation deformationOperation)
			{
			}

			// Token: 0x0600117A RID: 4474 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600117A")]
			[Address(RVA = "0x2F25210", Offset = "0x2F23810", VA = "0x182F25210")]
			public void UnRegister(TarpStructure tarp)
			{
			}

			// Token: 0x0600117B RID: 4475 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600117B")]
			[Address(RVA = "0x2F25340", Offset = "0x2F23940", VA = "0x182F25340")]
			public void SetWobbling(TarpStructure tarp)
			{
			}

			// Token: 0x0600117C RID: 4476 RVA: 0x0000A9AC File Offset: 0x00008BAC
			[Token(Token = "0x600117C")]
			[Address(RVA = "0x2F25530", Offset = "0x2F23B30", VA = "0x182F25530")]
			private bool TryFindOperation(TarpStructure tarp, out TarpDeformationSystem.DeformationOperation operation)
			{
				return default(bool);
			}

			// Token: 0x0600117D RID: 4477 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600117D")]
			[Address(RVA = "0x2F25A20", Offset = "0x2F24020", VA = "0x182F25A20")]
			public void Terminate(TarpDeformationSystem.DeformationOperation operation)
			{
			}

			// Token: 0x0600117E RID: 4478 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x600117E")]
			[Address(RVA = "0x2F25D40", Offset = "0x2F24340", VA = "0x182F25D40")]
			private TarpDeformationEffector GetEffector()
			{
				return null;
			}

			// Token: 0x0600117F RID: 4479 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600117F")]
			[Address(RVA = "0x2F25E90", Offset = "0x2F24490", VA = "0x182F25E90")]
			public DeformationSubSystem()
			{
			}

			// Token: 0x040008EE RID: 2286
			[Token(Token = "0x40008EE")]
			[FieldOffset(Offset = "0x10")]
			public TarpDeformationEffector _effectorPrefab;

			// Token: 0x040008EF RID: 2287
			[Token(Token = "0x40008EF")]
			[FieldOffset(Offset = "0x18")]
			public DeformationMethods _postFinishedMethod;

			// Token: 0x040008F0 RID: 2288
			[Token(Token = "0x40008F0")]
			[FieldOffset(Offset = "0x20")]
			public List<TarpDeformationSystem.DeformationOperation> _pendingOperations;

			// Token: 0x040008F1 RID: 2289
			[Token(Token = "0x40008F1")]
			[FieldOffset(Offset = "0x28")]
			public List<TarpDeformationSystem.DeformationOperation> _runningOperations;

			// Token: 0x040008F2 RID: 2290
			[Token(Token = "0x40008F2")]
			[FieldOffset(Offset = "0x30")]
			private Queue<TarpDeformationEffector> _pooledEffectors;
		}

		// Token: 0x02000241 RID: 577
		[Token(Token = "0x2000241")]
		[Serializable]
		public class DeformationOperation
		{
			// Token: 0x06001180 RID: 4480 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001180")]
			[Address(RVA = "0x2F26050", Offset = "0x2F24650", VA = "0x182F26050")]
			public void Begin(TarpDeformationEffector effector)
			{
			}

			// Token: 0x06001181 RID: 4481 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001181")]
			[Address(RVA = "0x2F26200", Offset = "0x2F24800", VA = "0x182F26200")]
			public void Finish()
			{
			}

			// Token: 0x06001182 RID: 4482 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001182")]
			[Address(RVA = "0x2F26300", Offset = "0x2F24900", VA = "0x182F26300")]
			public void SetWobbling()
			{
			}

			// Token: 0x06001183 RID: 4483 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001183")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public DeformationOperation()
			{
			}

			// Token: 0x040008F3 RID: 2291
			[Token(Token = "0x40008F3")]
			[FieldOffset(Offset = "0x10")]
			public DeformationMethods _method;

			// Token: 0x040008F4 RID: 2292
			[Token(Token = "0x40008F4")]
			[FieldOffset(Offset = "0x18")]
			public TarpStructure _tarp;

			// Token: 0x040008F5 RID: 2293
			[Token(Token = "0x40008F5")]
			[FieldOffset(Offset = "0x20")]
			public TarpDeformationEffector _effector;

			// Token: 0x040008F6 RID: 2294
			[Token(Token = "0x40008F6")]
			[FieldOffset(Offset = "0x28")]
			public bool _isFinished;
		}
	}
}
