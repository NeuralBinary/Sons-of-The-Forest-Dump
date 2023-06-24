using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Internal
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	[Serializable]
	public class EventDelegate
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E7")]
		public MonoBehaviour target
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x2667F60", Offset = "0x2666560", VA = "0x182667F60")]
			set
			{
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E8")]
		public string methodName
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x2668100", Offset = "0x2666700", VA = "0x182668100")]
			set
			{
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000E9")]
		public EventDelegate.Parameter[] parameters
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x26682A0", Offset = "0x26668A0", VA = "0x1826682A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x170000EA")]
		public bool isValid
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x26682D0", Offset = "0x26668D0", VA = "0x1826682D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x170000EB")]
		public bool isEnabled
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x26683D0", Offset = "0x26669D0", VA = "0x1826683D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public EventDelegate()
		{
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x2668570", Offset = "0x2666B70", VA = "0x182668570")]
		public EventDelegate(EventDelegate.Callback call)
		{
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x2668580", Offset = "0x2666B80", VA = "0x182668580")]
		public EventDelegate(MonoBehaviour target, string methodName)
		{
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x2668660", Offset = "0x2666C60", VA = "0x182668660")]
		private static string GetMethodName(EventDelegate.Callback callback)
		{
			return null;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x26686B0", Offset = "0x2666CB0", VA = "0x1826686B0")]
		private static bool IsValid(EventDelegate.Callback callback)
		{
			return default(bool);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x26686E0", Offset = "0x2666CE0", VA = "0x1826686E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x2668A90", Offset = "0x2667090", VA = "0x182668A90", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x2668AE0", Offset = "0x26670E0", VA = "0x182668AE0")]
		private void Set(EventDelegate.Callback call)
		{
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x2668580", Offset = "0x2666B80", VA = "0x182668580")]
		public void Set(MonoBehaviour target, string methodName)
		{
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x2668D30", Offset = "0x2667330", VA = "0x182668D30")]
		private void Cache()
		{
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x26696D0", Offset = "0x2667CD0", VA = "0x1826696D0")]
		public bool Execute()
		{
			return default(bool);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x2669ED0", Offset = "0x26684D0", VA = "0x182669ED0")]
		public void Clear()
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x266A110", Offset = "0x2668710", VA = "0x18266A110", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x266A2D0", Offset = "0x26688D0", VA = "0x18266A2D0")]
		public static void Execute(List<EventDelegate> list)
		{
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00003648 File Offset: 0x00001848
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x266A440", Offset = "0x2668A40", VA = "0x18266A440")]
		public static bool IsValid(List<EventDelegate> list)
		{
			return default(bool);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x266A500", Offset = "0x2668B00", VA = "0x18266A500")]
		public static EventDelegate Set(List<EventDelegate> list, EventDelegate.Callback callback)
		{
			return null;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x266A5C0", Offset = "0x2668BC0", VA = "0x18266A5C0")]
		public static void Set(List<EventDelegate> list, EventDelegate del)
		{
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x266A640", Offset = "0x2668C40", VA = "0x18266A640")]
		public static EventDelegate Add(List<EventDelegate> list, EventDelegate.Callback callback)
		{
			return null;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x266A6A0", Offset = "0x2668CA0", VA = "0x18266A6A0")]
		public static EventDelegate Add(List<EventDelegate> list, EventDelegate.Callback callback, bool oneShot)
		{
			return null;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x266A810", Offset = "0x2668E10", VA = "0x18266A810")]
		public static void Add(List<EventDelegate> list, EventDelegate ev)
		{
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x266A890", Offset = "0x2668E90", VA = "0x18266A890")]
		public static void Add(List<EventDelegate> list, EventDelegate ev, bool oneShot)
		{
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x266ABB0", Offset = "0x26691B0", VA = "0x18266ABB0")]
		public static bool Remove(List<EventDelegate> list, EventDelegate.Callback callback)
		{
			return default(bool);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x266AC90", Offset = "0x2669290", VA = "0x18266AC90")]
		public static bool Remove(List<EventDelegate> list, EventDelegate ev)
		{
			return default(bool);
		}

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MonoBehaviour mTarget;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string mMethodName;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private EventDelegate.Parameter[] mParameters;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x28")]
		public bool oneShot;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		private EventDelegate.Callback mCachedCallback;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		private bool mRawDelegate;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x39")]
		[NonSerialized]
		private bool mCached;

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		private MethodInfo mMethod;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		private ParameterInfo[] mParameterInfos;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		private object[] mArgs;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x0")]
		private static int s_Hash;

		// Token: 0x02000069 RID: 105
		[Token(Token = "0x2000069")]
		[Serializable]
		public class Parameter
		{
			// Token: 0x060003BF RID: 959 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x266AE40", Offset = "0x2669440", VA = "0x18266AE40")]
			public Parameter()
			{
			}

			// Token: 0x060003C0 RID: 960 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x266AF30", Offset = "0x2669530", VA = "0x18266AF30")]
			public Parameter(UnityEngine.Object obj, string field)
			{
			}

			// Token: 0x060003C1 RID: 961 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x266B0F0", Offset = "0x26696F0", VA = "0x18266B0F0")]
			public Parameter(object val)
			{
			}

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x060003C2 RID: 962 RVA: 0x00002082 File Offset: 0x00000282
			// (set) Token: 0x060003C3 RID: 963 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000EC")]
			public object value
			{
				[Token(Token = "0x60003C2")]
				[Address(RVA = "0x266B250", Offset = "0x2669850", VA = "0x18266B250")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003C3")]
				[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
				set
				{
				}
			}

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x060003C4 RID: 964 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x170000ED")]
			public Type type
			{
				[Token(Token = "0x60003C4")]
				[Address(RVA = "0x266B660", Offset = "0x2669C60", VA = "0x18266B660")]
				get
				{
					return null;
				}
			}

			// Token: 0x040002C9 RID: 713
			[Token(Token = "0x40002C9")]
			[FieldOffset(Offset = "0x10")]
			public UnityEngine.Object obj;

			// Token: 0x040002CA RID: 714
			[Token(Token = "0x40002CA")]
			[FieldOffset(Offset = "0x18")]
			public string field;

			// Token: 0x040002CB RID: 715
			[Token(Token = "0x40002CB")]
			[FieldOffset(Offset = "0x20")]
			[NonSerialized]
			private object mValue;

			// Token: 0x040002CC RID: 716
			[Token(Token = "0x40002CC")]
			[FieldOffset(Offset = "0x28")]
			[NonSerialized]
			public Type expectedType;

			// Token: 0x040002CD RID: 717
			[Token(Token = "0x40002CD")]
			[FieldOffset(Offset = "0x30")]
			[NonSerialized]
			public bool cached;

			// Token: 0x040002CE RID: 718
			[Token(Token = "0x40002CE")]
			[FieldOffset(Offset = "0x38")]
			[NonSerialized]
			public PropertyInfo propInfo;

			// Token: 0x040002CF RID: 719
			[Token(Token = "0x40002CF")]
			[FieldOffset(Offset = "0x40")]
			[NonSerialized]
			public FieldInfo fieldInfo;
		}

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x060003C6 RID: 966
		[Token(Token = "0x200006A")]
		public delegate void Callback();
	}
}
