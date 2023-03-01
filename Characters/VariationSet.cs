using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Characters
{
	// Token: 0x02000811 RID: 2065
	[Token(Token = "0x2000811")]
	[Serializable]
	public class VariationSet
	{
		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060036CB RID: 14027 RVA: 0x0000FFF0 File Offset: 0x0000E1F0
		[Token(Token = "0x170006FA")]
		public bool IsExclusive
		{
			[Token(Token = "0x60036CB")]
			[Address(RVA = "0x6B3E80", Offset = "0x6B2E80", VA = "0x1806B3E80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060036CC RID: 14028 RVA: 0x00010008 File Offset: 0x0000E208
		[Token(Token = "0x170006FB")]
		public int RepeatRollCount
		{
			[Token(Token = "0x60036CC")]
			[Address(RVA = "0x8CDC40", Offset = "0x8CCC40", VA = "0x1808CDC40")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CD")]
		[Address(RVA = "0x2EBFCE0", Offset = "0x2EBECE0", VA = "0x182EBFCE0")]
		public void SetRepeatRollCount(int count)
		{
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CE")]
		[Address(RVA = "0x2EC0130", Offset = "0x2EBF130", VA = "0x182EC0130")]
		public void UpdateVariationSetData()
		{
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CF")]
		[Address(RVA = "0x2EC0000", Offset = "0x2EBF000", VA = "0x182EC0000")]
		private void UpdateObjectsChanceSum(VariationSet.Subset subSet)
		{
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x00010020 File Offset: 0x0000E220
		[Token(Token = "0x60036D0")]
		[Address(RVA = "0x2EBFBF0", Offset = "0x2EBEBF0", VA = "0x182EBFBF0")]
		public VariationSet.Subset Apply(Random random, VariationSet.Subset subSet)
		{
			return VariationSet.Subset.Any;
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D1")]
		[Address(RVA = "0x2EBFB70", Offset = "0x2EBEB70", VA = "0x182EBFB70")]
		private void ApplyTargets(Random random, VariationSet.Subset subSet)
		{
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D2")]
		[Address(RVA = "0x2EBF740", Offset = "0x2EBE740", VA = "0x182EBF740")]
		private void ApplyObjectTargets(Random random, VariationSet.Subset subset)
		{
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D3")]
		[Address(RVA = "0x2EBF550", Offset = "0x2EBE550", VA = "0x182EBF550")]
		private void ApplyObjectTarget(VariationSet.ObjectTarget eachTarget, bool shouldEnable, Random random)
		{
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x00010038 File Offset: 0x0000E238
		[Token(Token = "0x60036D4")]
		[Address(RVA = "0x2EBF070", Offset = "0x2EBE070", VA = "0x182EBF070")]
		private VariationSet.Subset ApplyExclusive(Random random, VariationSet.Subset subSet)
		{
			return VariationSet.Subset.Any;
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D5")]
		[Address(RVA = "0x2EBEE50", Offset = "0x2EBDE50", VA = "0x182EBEE50")]
		private void ApplyExclusiveObjectTarget(VariationSet.ObjectTarget target, bool shouldEnable, Random random)
		{
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D6")]
		[Address(RVA = "0x2EBFCF0", Offset = "0x2EBECF0", VA = "0x182EBFCF0")]
		public void ShowAll(bool value)
		{
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x00010050 File Offset: 0x0000E250
		[Token(Token = "0x60036D7")]
		[Address(RVA = "0x2EBFC80", Offset = "0x2EBEC80", VA = "0x182EBFC80")]
		private float GetObjectsChance(int chance, VariationSet.Subset subSet)
		{
			return default(float);
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D8")]
		[Address(RVA = "0x2EC0140", Offset = "0x2EBF140", VA = "0x182EC0140")]
		public VariationSet()
		{
		}

		// Token: 0x04002F00 RID: 12032
		[Token(Token = "0x4002F00")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("_targets")]
		[SerializeField]
		private List<VariationSet.ObjectTarget> _objectTargets;

		// Token: 0x04002F01 RID: 12033
		[Token(Token = "0x4002F01")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _exclusive;

		// Token: 0x04002F02 RID: 12034
		[Token(Token = "0x4002F02")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool _additiveChance;

		// Token: 0x04002F03 RID: 12035
		[Token(Token = "0x4002F03")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _repeatRollCount;

		// Token: 0x04002F04 RID: 12036
		[Token(Token = "0x4002F04")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _shouldInstantiateTargets;

		// Token: 0x04002F05 RID: 12037
		[Token(Token = "0x4002F05")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _spawnTargetRoot;

		// Token: 0x04002F06 RID: 12038
		[Token(Token = "0x4002F06")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("_chanceSum")]
		private int _objectsChanceSum;

		// Token: 0x02000812 RID: 2066
		[Token(Token = "0x2000812")]
		public enum Subset
		{
			// Token: 0x04002F08 RID: 12040
			[Token(Token = "0x4002F08")]
			Any,
			// Token: 0x04002F09 RID: 12041
			[Token(Token = "0x4002F09")]
			Primitive,
			// Token: 0x04002F0A RID: 12042
			[Token(Token = "0x4002F0A")]
			Clothed,
			// Token: 0x04002F0B RID: 12043
			[Token(Token = "0x4002F0B")]
			Creepy
		}

		// Token: 0x02000813 RID: 2067
		[Token(Token = "0x2000813")]
		[Serializable]
		public class MaterialTarget
		{
			// Token: 0x060036D9 RID: 14041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036D9")]
			[Address(RVA = "0x2EB7E80", Offset = "0x2EB6E80", VA = "0x182EB7E80")]
			public void Apply()
			{
			}

			// Token: 0x060036DA RID: 14042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036DA")]
			[Address(RVA = "0x2EB7EB0", Offset = "0x2EB6EB0", VA = "0x182EB7EB0")]
			public MaterialTarget()
			{
			}

			// Token: 0x04002F0C RID: 12044
			[Token(Token = "0x4002F0C")]
			[FieldOffset(Offset = "0x10")]
			public Renderer _targetRenderer;

			// Token: 0x04002F0D RID: 12045
			[Token(Token = "0x4002F0D")]
			[FieldOffset(Offset = "0x18")]
			public Material[] _materials;

			// Token: 0x04002F0E RID: 12046
			[Token(Token = "0x4002F0E")]
			[FieldOffset(Offset = "0x20")]
			[Min(1f)]
			public int _chance;
		}

		// Token: 0x02000814 RID: 2068
		[Token(Token = "0x2000814")]
		[Serializable]
		public class ObjectTarget
		{
			// Token: 0x060036DB RID: 14043 RVA: 0x00010068 File Offset: 0x0000E268
			[Token(Token = "0x60036DB")]
			[Address(RVA = "0x2EB89A0", Offset = "0x2EB79A0", VA = "0x182EB89A0")]
			public bool IsValid(VariationSet.Subset subSet)
			{
				return default(bool);
			}

			// Token: 0x060036DC RID: 14044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036DC")]
			[Address(RVA = "0x2EB89C0", Offset = "0x2EB79C0", VA = "0x182EB89C0")]
			public void UpdateMaterialsChanceSum()
			{
			}

			// Token: 0x060036DD RID: 14045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036DD")]
			[Address(RVA = "0x2EB8860", Offset = "0x2EB7860", VA = "0x182EB8860")]
			public void ApplyMaterialTargets(Random random)
			{
			}

			// Token: 0x060036DE RID: 14046 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036DE")]
			[Address(RVA = "0x26A5900", Offset = "0x26A4900", VA = "0x1826A5900")]
			public ObjectTarget()
			{
			}

			// Token: 0x04002F0F RID: 12047
			[Token(Token = "0x4002F0F")]
			[FieldOffset(Offset = "0x10")]
			public GameObject _target;

			// Token: 0x04002F10 RID: 12048
			[Token(Token = "0x4002F10")]
			[FieldOffset(Offset = "0x18")]
			[Min(1f)]
			public int _chance;

			// Token: 0x04002F11 RID: 12049
			[Token(Token = "0x4002F11")]
			[FieldOffset(Offset = "0x1C")]
			public VariationSet.Subset _subSet;

			// Token: 0x04002F12 RID: 12050
			[Token(Token = "0x4002F12")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			[HideInInspector]
			private int _materialsChanceSum;

			// Token: 0x04002F13 RID: 12051
			[Token(Token = "0x4002F13")]
			[FieldOffset(Offset = "0x28")]
			public VariationSet.MaterialTarget[] _materialTargets;

			// Token: 0x04002F14 RID: 12052
			[Token(Token = "0x4002F14")]
			[FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public GameObject _runtimeInstance;
		}
	}
}
