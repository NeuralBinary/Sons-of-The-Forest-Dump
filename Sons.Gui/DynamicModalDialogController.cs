using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Input;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;

namespace Sons.Gui
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	public class DynamicModalDialogController : MonoBehaviour
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		private event Action OnBackClicked
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x30034C0", Offset = "0x3001AC0", VA = "0x1830034C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x30035B0", Offset = "0x3001BB0", VA = "0x1830035B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		private event Action OnOption1Clicked
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x30036A0", Offset = "0x3001CA0", VA = "0x1830036A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x3003790", Offset = "0x3001D90", VA = "0x183003790")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000005")]
		private event Action OnOption2Clicked
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x3003880", Offset = "0x3001E80", VA = "0x183003880")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x3003970", Offset = "0x3001F70", VA = "0x183003970")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000006")]
		private event Action OnOption3Clicked
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x3003A60", Offset = "0x3002060", VA = "0x183003A60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x3003B50", Offset = "0x3002150", VA = "0x183003B50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000007")]
		private event Action OnCloseRequested
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x3003C40", Offset = "0x3002240", VA = "0x183003C40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x3003D30", Offset = "0x3002330", VA = "0x183003D30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000008")]
		private event Action<DynamicModalDialogController.Options> OnClosed
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x3003E20", Offset = "0x3002420", VA = "0x183003E20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x3003F90", Offset = "0x3002590", VA = "0x183003F90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x30034C0", Offset = "0x3001AC0", VA = "0x1830034C0")]
		public void AddOnBackClickedCallback(Action a)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x30036A0", Offset = "0x3001CA0", VA = "0x1830036A0")]
		public void AddOnOption1ClickedCallback(Action a)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x3003880", Offset = "0x3001E80", VA = "0x183003880")]
		public void AddOnOption2ClickedCallback(Action a)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x3003A60", Offset = "0x3002060", VA = "0x183003A60")]
		public void AddOnOption3ClickedCallback(Action a)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x3003C40", Offset = "0x3002240", VA = "0x183003C40")]
		public void AddOnCloseRequestedCallback(Action a)
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x3003E20", Offset = "0x3002420", VA = "0x183003E20")]
		public void AddOnClosedCallback(Action<DynamicModalDialogController.Options> a)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x17000004")]
		private bool BackEnabled
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x3004100", Offset = "0x3002700", VA = "0x183004100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x17000005")]
		private bool Option1Enabled
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x3004110", Offset = "0x3002710", VA = "0x183004110")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x17000006")]
		private bool Option2Enabled
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x3004120", Offset = "0x3002720", VA = "0x183004120")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x17000007")]
		private bool Option3Enabled
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x3004130", Offset = "0x3002730", VA = "0x183004130")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x17000008")]
		private bool ContentEnabled
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x3004140", Offset = "0x3002740", VA = "0x183004140")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x17000009")]
		private bool InputEnabled
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x3004150", Offset = "0x3002750", VA = "0x183004150")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000A")]
		public object[] Objects
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x8DD0B0", Offset = "0x8DB6B0", VA = "0x1808DD0B0")]
			set
			{
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x3004160", Offset = "0x3002760", VA = "0x183004160")]
		public void SetDefaultInputText(string text, bool isPassword)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x3004210", Offset = "0x3002810", VA = "0x183004210")]
		public void SetInputTextValidationCallback(TMP_InputField.OnValidateInput callback)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0", Slot = "4")]
		protected virtual DynamicModalDialogController.Options GetOptions()
		{
			return (DynamicModalDialogController.Options)0;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x3004280", Offset = "0x3002880", VA = "0x183004280")]
		private void ClearLocalizedStringArguments()
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x3004490", Offset = "0x3002A90", VA = "0x183004490", Slot = "5")]
		protected virtual void SetupLocalizedStringArguments()
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x3004500", Offset = "0x3002B00", VA = "0x183004500")]
		private void OnEnable()
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x3005050", Offset = "0x3003650", VA = "0x183005050")]
		private void RefreshLocalizedStrings()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x3005160", Offset = "0x3003760", VA = "0x183005160")]
		private void OnDisable()
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x3005690", Offset = "0x3003C90", VA = "0x183005690")]
		private void SetupGui()
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x3006940", Offset = "0x3004F40", VA = "0x183006940")]
		private void Close()
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x3006BF0", Offset = "0x30051F0", VA = "0x183006BF0", Slot = "6")]
		protected virtual void OnBack()
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x3006CC0", Offset = "0x30052C0", VA = "0x183006CC0", Slot = "7")]
		protected virtual void OnOption1()
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x3006D90", Offset = "0x3005390", VA = "0x183006D90", Slot = "8")]
		protected virtual void OnOption2()
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x3006E60", Offset = "0x3005460", VA = "0x183006E60", Slot = "9")]
		protected virtual void OnOption3()
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x3006F30", Offset = "0x3005530", VA = "0x183006F30")]
		private void Update()
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x3007190", Offset = "0x3005790", VA = "0x183007190")]
		public DynamicModalDialogController()
		{
		}

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x20")]
		[Header("Properties")]
		[SerializeField]
		private DynamicModalDialogController.EventSystemMode _eventSystemMode;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private DynamicModalDialogController.Options _options;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LocalizedString _title;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected LocalizedString _content;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected LocalizedString _inputLabel;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected LocalizedString _back;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected LocalizedString _option1;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected LocalizedString _option2;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected LocalizedString _option3;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private DynamicModalDialogController.BackgroundType _backgroundType;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private bool _localizeWithObjects;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x68")]
		[Header("Gui")]
		[SerializeField]
		private DynamicModalDialogGui _gui;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x70")]
		[Header("Debug")]
		public DynamicModalDialogController.Options Result;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x78")]
		public string UserInput;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x80")]
		private InputGamepadMenuHelper[] _cachedHelpers;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x88")]
		private object[] _objects;

		// Token: 0x02000011 RID: 17
		[Token(Token = "0x2000011")]
		[Flags]
		public enum Options
		{
			// Token: 0x0400007F RID: 127
			[Token(Token = "0x400007F")]
			BACK = 2,
			// Token: 0x04000080 RID: 128
			[Token(Token = "0x4000080")]
			OPTION1 = 4,
			// Token: 0x04000081 RID: 129
			[Token(Token = "0x4000081")]
			OPTION2 = 8,
			// Token: 0x04000082 RID: 130
			[Token(Token = "0x4000082")]
			OPTION3 = 16,
			// Token: 0x04000083 RID: 131
			[Token(Token = "0x4000083")]
			INPUT = 32,
			// Token: 0x04000084 RID: 132
			[Token(Token = "0x4000084")]
			CONTENT = 256
		}

		// Token: 0x02000012 RID: 18
		[Token(Token = "0x2000012")]
		public enum EventSystemMode
		{
			// Token: 0x04000086 RID: 134
			[Token(Token = "0x4000086")]
			NONE,
			// Token: 0x04000087 RID: 135
			[Token(Token = "0x4000087")]
			FORCED,
			// Token: 0x04000088 RID: 136
			[Token(Token = "0x4000088")]
			AUTO
		}

		// Token: 0x02000013 RID: 19
		[Token(Token = "0x2000013")]
		public enum BackgroundType
		{
			// Token: 0x0400008A RID: 138
			[Token(Token = "0x400008A")]
			OPAQUE,
			// Token: 0x0400008B RID: 139
			[Token(Token = "0x400008B")]
			CLEAR,
			// Token: 0x0400008C RID: 140
			[Token(Token = "0x400008C")]
			SEMI_TRANSPARENT
		}
	}
}
