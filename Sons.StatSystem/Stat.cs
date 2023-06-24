using System;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.StatSystem
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[Serializable]
	public abstract class Stat : IStat
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x3142AC0", Offset = "0x31410C0", VA = "0x183142AC0")]
		public string GetName()
		{
			return null;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x3142B50", Offset = "0x3141150", VA = "0x183142B50")]
		public Color GetGuiPropertyColor(bool hide)
		{
			return default(Color);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x3142CD0", Offset = "0x31412D0", VA = "0x183142CD0", Slot = "5")]
		public virtual string EditorGuiIconPath()
		{
			return null;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x661080", Offset = "0x65F680", VA = "0x180661080")]
		public void SetFadeRateMethod(Func<float> fadeRateMethod)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x3142D00", Offset = "0x3141300", VA = "0x183142D00")]
		public Texture GetEditorGuiIcon()
		{
			return null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2BC1090", Offset = "0x2BBF690", VA = "0x182BC1090")]
		protected Stat(Stat source)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x3142DC0", Offset = "0x31413C0", VA = "0x183142DC0")]
		public void CopyFrom(Stat source)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2B8D740", Offset = "0x2B8BD40", VA = "0x182B8D740")]
		protected Stat()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x3142E00", Offset = "0x3141400", VA = "0x183142E00")]
		public static Stat DrawStat(Stat value, GUIContent label)
		{
			return null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
		public float GetMax()
		{
			return 0f;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
		public float GetMin()
		{
			return 0f;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x71D350", Offset = "0x71B950", VA = "0x18071D350")]
		public float GetBase()
		{
			return 0f;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x6000016")]
		[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
		public float Sample()
		{
			return 0f;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x3142F00", Offset = "0x3141500", VA = "0x183142F00")]
		public float GetFactor()
		{
			return 0f;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x17000001")]
		public bool IsSigned
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x3142F20", Offset = "0x3141520", VA = "0x183142F20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x3142F40", Offset = "0x3141540", VA = "0x183142F40")]
		public float GetSignedFactor()
		{
			return 0f;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x3142F80", Offset = "0x3141580", VA = "0x183142F80")]
		public float SamplePercent()
		{
			return 0f;
		}

		// Token: 0x0600001B RID: 27
		[Token(Token = "0x600001B")]
		public abstract string GetToolTip();

		// Token: 0x0600001C RID: 28
		[Token(Token = "0x600001C")]
		public abstract string GetId();

		// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public virtual void OnValidate()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x3142FB0", Offset = "0x31415B0", VA = "0x183142FB0")]
		private float GetFadeRate()
		{
			return 0f;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x70B930", Offset = "0x709F30", VA = "0x18070B930")]
		private float GetRegenRate()
		{
			return 0f;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x3142FF0", Offset = "0x31415F0", VA = "0x183142FF0")]
		public void Adjust(float amount)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x3143030", Offset = "0x3141630", VA = "0x183143030", Slot = "9")]
		public virtual void Update(Vector3 worldPosition, float deltaTime)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2FBB2B0", Offset = "0x2FB98B0", VA = "0x182FBB2B0")]
		internal void SetDefaultValue(float value)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000023")]
		[Address(RVA = "0xA308B0", Offset = "0xA2EEB0", VA = "0x180A308B0")]
		protected internal void SetBaseValue(float value)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x3143130", Offset = "0x3141730", VA = "0x183143130")]
		public void SetCurrentValue(float value)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x5EA830", Offset = "0x5E8E30", VA = "0x1805EA830")]
		protected internal void SetMin(float value)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x5EA850", Offset = "0x5E8E50", VA = "0x1805EA850")]
		protected internal void SetMax(float value)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x3143180", Offset = "0x3141780", VA = "0x183143180")]
		protected internal void SetFadeRate(float value)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x26F9F30", Offset = "0x26F8530", VA = "0x1826F9F30")]
		protected internal void SetRegenRate(float value)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x31431E0", Offset = "0x31417E0", VA = "0x1831431E0")]
		public string GetReadout()
		{
			return null;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x3143260", Offset = "0x3141860", VA = "0x183143260")]
		public void GetReadout(StringBuilder sb)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x3143540", Offset = "0x3141B40", VA = "0x183143540", Slot = "10")]
		public virtual string InspectorReadout()
		{
			return null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x3143730", Offset = "0x3141D30", VA = "0x183143730")]
		private string GetTimeToBaseReadout()
		{
			return null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x31438C0", Offset = "0x3141EC0", VA = "0x1831438C0")]
		public void Initialize()
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x3143930", Offset = "0x3141F30", VA = "0x183143930")]
		public void Randomize(float randomizePercentOffset)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000002")]
		private string InspectorId
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x222E1B0", Offset = "0x222C7B0", VA = "0x18222E1B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x31439C0", Offset = "0x3141FC0", VA = "0x1831439C0")]
		public Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x3143A20", Offset = "0x3142020", VA = "0x183143A20")]
		public Color GetGuiColorClass()
		{
			return default(Color);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x3143AD0", Offset = "0x31420D0", VA = "0x183143AD0")]
		private bool HideBase()
		{
			return default(bool);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0")]
		private bool HideFadeRate()
		{
			return default(bool);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x9D9870", Offset = "0x9D7E70", VA = "0x1809D9870")]
		private bool HideRegenRate()
		{
			return default(bool);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x3143AE0", Offset = "0x31420E0", VA = "0x183143AE0")]
		private bool HideMin()
		{
			return default(bool);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x620360", Offset = "0x61E960", VA = "0x180620360")]
		private bool HideMax()
		{
			return default(bool);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void BeginListItem(Stat stat)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private static void ShowToolTip(Stat stat)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void EndListItem(Stat stat)
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _currentValue;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _baseValue;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("_offsetDecay")]
		[SerializeField]
		[Min(0f)]
		private float _fadeRate;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Min(0f)]
		private float _regenRate;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _min;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _max;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x28")]
		private string _statName;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x30")]
		protected internal Color _guiColor;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x40")]
		private Texture _editorGuiIcon;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x48")]
		protected bool _hideFadeRate;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x49")]
		protected bool _hideRegenRate;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x4A")]
		protected bool _hideBase;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x4B")]
		protected bool _hideMin;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x4C")]
		protected bool _hideMax;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x4D")]
		protected bool _hideReadout;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x50")]
		private Func<float> _fadeRateMethod;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x58")]
		private float _defaultValue;
	}
}
