using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Assemblies.Sons.Input;
using Il2CppDummyDll;
using TheForest.Utils;
using UnityEngine;
using UnityEngine.InputSystem;
using Valve.VR;

namespace Sons.Input
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public class InputSystem : MonoBehaviour, IInputChangedReceiver
	{
		// Token: 0x06000084 RID: 132 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x306B990", Offset = "0x3069F90", VA = "0x18306B990")]
		public static List<InputSystem.VRAction> FindAll(InputSystem.ActionId action)
		{
			return null;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x17000006")]
		public static float DelayedActionFill
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x306BC30", Offset = "0x306A230", VA = "0x18306BC30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000023B4 File Offset: 0x000005B4
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000007")]
		public static bool UsingDualshock
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x306BC80", Offset = "0x306A280", VA = "0x18306BC80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x306BCD0", Offset = "0x306A2D0", VA = "0x18306BCD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000088 RID: 136 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000089 RID: 137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1400000C")]
		public static event Action<string> OnUpdate
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x306BD30", Offset = "0x306A330", VA = "0x18306BD30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x306BEF0", Offset = "0x306A4F0", VA = "0x18306BEF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000023CC File Offset: 0x000005CC
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000008")]
		public static bool InvertLookY
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x306C0B0", Offset = "0x306A6B0", VA = "0x18306C0B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x306C100", Offset = "0x306A700", VA = "0x18306C100")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000023E4 File Offset: 0x000005E4
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000009")]
		public static bool SprintToggle
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x306C160", Offset = "0x306A760", VA = "0x18306C160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x306C1B0", Offset = "0x306A7B0", VA = "0x18306C1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000023FC File Offset: 0x000005FC
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000A")]
		public static bool CrouchToggle
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x306C210", Offset = "0x306A810", VA = "0x18306C210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x306C260", Offset = "0x306A860", VA = "0x18306C260")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00002414 File Offset: 0x00000614
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000B")]
		public static bool RumbleEnabled
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x306C2C0", Offset = "0x306A8C0", VA = "0x18306C2C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x306C310", Offset = "0x306A910", VA = "0x18306C310")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000242C File Offset: 0x0000062C
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000C")]
		public static float MouseXSensitivity
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x306C370", Offset = "0x306A970", VA = "0x18306C370")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x306C3C0", Offset = "0x306A9C0", VA = "0x18306C3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00002444 File Offset: 0x00000644
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000D")]
		public static float MouseYSensitivity
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x306C420", Offset = "0x306AA20", VA = "0x18306C420")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x306C470", Offset = "0x306AA70", VA = "0x18306C470")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000245C File Offset: 0x0000065C
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000E")]
		public static float GamePadXSensitivity
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x306C4D0", Offset = "0x306AAD0", VA = "0x18306C4D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x306C520", Offset = "0x306AB20", VA = "0x18306C520")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00002474 File Offset: 0x00000674
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000F")]
		public static float GamePadYSensitivity
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x306C580", Offset = "0x306AB80", VA = "0x18306C580")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x306C5D0", Offset = "0x306ABD0", VA = "0x18306C5D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000248C File Offset: 0x0000068C
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000010")]
		public static float GamePadDeadzone
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x306C630", Offset = "0x306AC30", VA = "0x18306C630")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x306C690", Offset = "0x306AC90", VA = "0x18306C690")]
			set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000011")]
		public static SonsInputMapping InputMapping
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x306C710", Offset = "0x306AD10", VA = "0x18306C710")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600009D RID: 157 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x17000012")]
		public static bool UserInputBindingLoaded
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x306C760", Offset = "0x306AD60", VA = "0x18306C760")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600009E RID: 158 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600009F RID: 159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1400000D")]
		public static event System.Action OnInputBindingSettingsLoaded
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x306C7B0", Offset = "0x306ADB0", VA = "0x18306C7B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x306C900", Offset = "0x306AF00", VA = "0x18306C900")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x306CA50", Offset = "0x306B050", VA = "0x18306CA50")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void ClearOldInstance()
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x306CB10", Offset = "0x306B110", VA = "0x18306CB10")]
		private void Awake()
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void InitializeHooks()
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x306CBD0", Offset = "0x306B1D0", VA = "0x18306CBD0")]
		private bool GetButtonOverride(string arg)
		{
			return default(bool);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x306CCC0", Offset = "0x306B2C0", VA = "0x18306CCC0")]
		private bool GetButtonDownOverride(string arg)
		{
			return default(bool);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x306CDB0", Offset = "0x306B3B0", VA = "0x18306CDB0")]
		private bool GetButtonUpOverride(string arg)
		{
			return default(bool);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x306CEA0", Offset = "0x306B4A0", VA = "0x18306CEA0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x306CF50", Offset = "0x306B550", VA = "0x18306CF50")]
		public static bool GetState(InputState state)
		{
			return default(bool);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x306D060", Offset = "0x306B660", VA = "0x18306D060")]
		public static void SetState(InputState state, bool enabled)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x306D8E0", Offset = "0x306BEE0", VA = "0x18306D8E0")]
		private static void InitializedStates()
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x306E120", Offset = "0x306C720", VA = "0x18306E120")]
		public static void Apply(Dictionary<InputState, bool> states, Dictionary<InputState, InputActionMap> maps)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x306EA40", Offset = "0x306D040", VA = "0x18306EA40")]
		private static bool DisableAllMaps(Dictionary<InputState, bool> states, Dictionary<InputState, InputActionMap> maps, InputState inputState)
		{
			return default(bool);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x306EAC0", Offset = "0x306D0C0", VA = "0x18306EAC0")]
		private static bool AppliedExclusiveMap(Dictionary<InputState, bool> states, Dictionary<InputState, InputActionMap> maps, InputState inputState, bool enableSourceMap = true)
		{
			return default(bool);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x306ED00", Offset = "0x306D300", VA = "0x18306ED00")]
		public static void ForceRefreshState()
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x306F260", Offset = "0x306D860", VA = "0x18306F260")]
		private static void SetVRMappingExclusive(KeyMapCategory exclusiveCategory)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x17000013")]
		public static bool IsGamePad
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x306F330", Offset = "0x306D930", VA = "0x18306F330")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002564 File Offset: 0x00000764
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000014")]
		public static bool WasGamePad
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x306F3C0", Offset = "0x306D9C0", VA = "0x18306F3C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x306F420", Offset = "0x306DA20", VA = "0x18306F420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x17000015")]
		public static bool IsMouseLocked
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x306F480", Offset = "0x306DA80", VA = "0x18306F480")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x17000016")]
		public static bool anyKeyDown
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x262A590", Offset = "0x2628B90", VA = "0x18262A590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x306F520", Offset = "0x306DB20", VA = "0x18306F520")]
		public static bool IsPressed(InputSystem.Action button)
		{
			return default(bool);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x306F610", Offset = "0x306DC10", VA = "0x18306F610")]
		public static bool GetButtonDown(InputSystem.Action button)
		{
			return default(bool);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x306F7A0", Offset = "0x306DDA0", VA = "0x18306F7A0")]
		public static bool GetButtonUp(InputSystem.Action button)
		{
			return default(bool);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x306F9A0", Offset = "0x306DFA0", VA = "0x18306F9A0")]
		public static bool GetButtonPress(InputSystem.Action button)
		{
			return default(bool);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x306FA80", Offset = "0x306E080", VA = "0x18306FA80")]
		public static bool IsPastButtonPress(InputSystem.Action button)
		{
			return default(bool);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002624 File Offset: 0x00000824
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x306FB60", Offset = "0x306E160", VA = "0x18306FB60")]
		public static bool GetKeyDown(KeyCode key)
		{
			return default(bool);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000263C File Offset: 0x0000083C
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x306FBB0", Offset = "0x306E1B0", VA = "0x18306FBB0")]
		public static bool GetKeyUp(KeyCode key)
		{
			return default(bool);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002654 File Offset: 0x00000854
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x306FC00", Offset = "0x306E200", VA = "0x18306FC00")]
		public static bool GetKey(KeyCode key)
		{
			return default(bool);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000266C File Offset: 0x0000086C
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x306FC50", Offset = "0x306E250", VA = "0x18306FC50")]
		public static bool GetMouseButtonDown(int index)
		{
			return default(bool);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002684 File Offset: 0x00000884
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x306FCA0", Offset = "0x306E2A0", VA = "0x18306FCA0")]
		public static bool GetMouseButtonUp(int index)
		{
			return default(bool);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000269C File Offset: 0x0000089C
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x306FCF0", Offset = "0x306E2F0", VA = "0x18306FCF0")]
		public static bool GetMouseButton(int index)
		{
			return default(bool);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000026B4 File Offset: 0x000008B4
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x306FD40", Offset = "0x306E340", VA = "0x18306FD40")]
		public static bool GetButton(InputSystem.Action button)
		{
			return default(bool);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000026CC File Offset: 0x000008CC
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x306FE00", Offset = "0x306E400", VA = "0x18306FE00")]
		public static bool GetButtonAfterDelay(InputSystem.Action button, float totalDuration, bool autoRepeat = false)
		{
			return default(bool);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000026E4 File Offset: 0x000008E4
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x3070330", Offset = "0x306E930", VA = "0x183070330")]
		public static bool MatchesDelayedAction(InputSystem.Action action)
		{
			return default(bool);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x30703C0", Offset = "0x306E9C0", VA = "0x1830703C0")]
		public static void ResetDelayedAction()
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x30704E0", Offset = "0x306EAE0", VA = "0x1830704E0")]
		public static void LogDebugInfo()
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000026FC File Offset: 0x000008FC
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x3070770", Offset = "0x306ED70", VA = "0x183070770")]
		public static float GetAxis(InputSystem.Action axis)
		{
			return 0f;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x30708A0", Offset = "0x306EEA0", VA = "0x1830708A0")]
		private static void InitializeUnityMapping()
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x30717C0", Offset = "0x306FDC0", VA = "0x1830717C0")]
		private static void TryLoadUserInputBinding()
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x3071870", Offset = "0x306FE70", VA = "0x183071870")]
		public static void LoadInputBindingsSettings()
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x30719C0", Offset = "0x306FFC0", VA = "0x1830719C0")]
		public static void SaveInputBindingsSettings()
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x3071AD0", Offset = "0x30700D0", VA = "0x183071AD0")]
		public static void ClearInputBindingsSettings(params string[] groups)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x3071D60", Offset = "0x3070360", VA = "0x183071D60")]
		public static void ClearInputBindingsSettings()
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002714 File Offset: 0x00000914
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x3071E00", Offset = "0x3070400", VA = "0x183071E00")]
		public static float GetAxisDown(InputSystem.Action axis)
		{
			return 0f;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000272C File Offset: 0x0000092C
		[Token(Token = "0x17000017")]
		public static Vector3 MousePosition
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x3071E90", Offset = "0x3070490", VA = "0x183071E90")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x17000018")]
		public static int TouchCount
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x3071FD0", Offset = "0x30705D0", VA = "0x183071FD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x3072020", Offset = "0x3070620", VA = "0x183072020")]
		public static Touch GetTouch(int index)
		{
			return default(Touch);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x30720D0", Offset = "0x30706D0", VA = "0x1830720D0", Slot = "4")]
		public void InputChanged(string inputId)
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000019")]
		public static InputSystem.SoftwareCursor Cursor
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x30721E0", Offset = "0x30707E0", VA = "0x1830721E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x3072240", Offset = "0x3070840", VA = "0x183072240")]
		public static bool Rumble(string rumbleProfileId, bool skipGamePadCheck = false)
		{
			return default(bool);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000278C File Offset: 0x0000098C
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x3072310", Offset = "0x3070910", VA = "0x183072310")]
		public static bool Rumble(float lowFrequency, float highFrequency, float time)
		{
			return default(bool);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x3072570", Offset = "0x3070B70", VA = "0x183072570")]
		public static bool TryGetNewInput(InputSystem.Action axis, out float result)
		{
			return default(bool);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000027BC File Offset: 0x000009BC
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x3072640", Offset = "0x3070C40", VA = "0x183072640")]
		public static bool TryGetIsPressed(InputSystem.Action button, out bool result)
		{
			return default(bool);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000027D4 File Offset: 0x000009D4
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x3072750", Offset = "0x3070D50", VA = "0x183072750")]
		public static bool TryGetNewInput(InputState state, InputSystem.Action button, out bool result)
		{
			return default(bool);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000027EC File Offset: 0x000009EC
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x30727F0", Offset = "0x3070DF0", VA = "0x1830727F0")]
		public static bool TryGetNewInput(InputSystem.Action button, out bool result)
		{
			return default(bool);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002804 File Offset: 0x00000A04
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x30728B0", Offset = "0x3070EB0", VA = "0x1830728B0")]
		public static bool TryGetNewInputUp(InputSystem.Action button, out bool result)
		{
			return default(bool);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x30729F0", Offset = "0x3070FF0", VA = "0x1830729F0")]
		private static InputAction GetInputActionFromName(InputState state, InputSystem.Action button)
		{
			return null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x3072BA0", Offset = "0x30711A0", VA = "0x183072BA0")]
		public static InputAction GetInputActionFromName(InputSystem.Action button)
		{
			return null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x3072BF0", Offset = "0x30711F0", VA = "0x183072BF0")]
		public static InputAction GetInputActionFromName(string actionName)
		{
			return null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000281C File Offset: 0x00000A1C
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x3072D30", Offset = "0x3071330", VA = "0x183072D30")]
		public static bool GetNewInputAction(InputState state, InputSystem.Action button)
		{
			return default(bool);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002834 File Offset: 0x00000A34
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x3072DF0", Offset = "0x30713F0", VA = "0x183072DF0")]
		public static bool GetNewInputAction(InputSystem.Action button)
		{
			return default(bool);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x3072ED0", Offset = "0x30714D0", VA = "0x183072ED0")]
		private static void SetInputMappingEnabled(InputActionMap target, bool value)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x3072F60", Offset = "0x3071560", VA = "0x183072F60")]
		public static void RegisterActionUpdate(InputSystem.Action find, Action<InputAction.CallbackContext> startedCallback, Action<InputAction.CallbackContext> performedCallback, Action<InputAction.CallbackContext> cancelledCallback, [Optional] System.Action alreadyStartedCallback)
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x3073130", Offset = "0x3071730", VA = "0x183073130")]
		private static void RegisterActionUpdateInternal(Action<InputAction.CallbackContext> startedCallback, Action<InputAction.CallbackContext> performedCallback, Action<InputAction.CallbackContext> cancelledCallback, InputAction action, System.Action alreadyStartedCallback)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x3073280", Offset = "0x3071880", VA = "0x183073280")]
		public static void RegisterActionUpdate(InputState inputState, InputSystem.Action find, Action<InputAction.CallbackContext> startedCallback, Action<InputAction.CallbackContext> performedCallback, Action<InputAction.CallbackContext> cancelledCallback, [Optional] System.Action alreadyStartedCallback)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x3073420", Offset = "0x3071A20", VA = "0x183073420")]
		public static void UnregisterActionUpdate(InputSystem.Action find, Action<InputAction.CallbackContext> startedCallback, Action<InputAction.CallbackContext> performedCallback, Action<InputAction.CallbackContext> cancelledCallback)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x3073550", Offset = "0x3071B50", VA = "0x183073550")]
		public static void UnregisterActionUpdate(InputState inputState, InputSystem.Action find, Action<InputAction.CallbackContext> startedCallback, Action<InputAction.CallbackContext> performedCallback, Action<InputAction.CallbackContext> cancelledCallback)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x3073690", Offset = "0x3071C90", VA = "0x183073690")]
		private static void UnregisterActionUpdateInternal(Action<InputAction.CallbackContext> startedCallback, Action<InputAction.CallbackContext> performedCallback, Action<InputAction.CallbackContext> cancelledCallback, InputAction action)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000284C File Offset: 0x00000A4C
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x3073780", Offset = "0x3071D80", VA = "0x183073780")]
		public static float GetTimeoutCompletionPercentage(InputSystem.Action find)
		{
			return 0f;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002864 File Offset: 0x00000A64
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x3073830", Offset = "0x3071E30", VA = "0x183073830")]
		public static float GetTimeoutCompletionPercentage(InputState inputState, InputSystem.Action find)
		{
			return 0f;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x30738C0", Offset = "0x3071EC0", VA = "0x1830738C0")]
		public static void ForceUpdate()
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000287C File Offset: 0x00000A7C
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001A")]
		public static Vector3 VRMouseScreenPos
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x30739C0", Offset = "0x3071FC0", VA = "0x1830739C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x3073A30", Offset = "0x3072030", VA = "0x183073A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x3073AA0", Offset = "0x30720A0", VA = "0x183073AA0")]
		private static void SetupVRInput()
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002894 File Offset: 0x00000A94
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x3073B00", Offset = "0x3072100", VA = "0x183073B00")]
		public static bool ActionSetReady(SteamVR_ActionSet set, SteamVR_Action actionQuery)
		{
			return default(bool);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x3073D30", Offset = "0x3072330", VA = "0x183073D30")]
		private static void SetVRMapping(KeyMapCategory category, bool enabled)
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x3073DC0", Offset = "0x30723C0", VA = "0x183073DC0")]
		private static void SetVRMapping(string actionSetName, bool enabled)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000ED")]
		internal static T GetOrCacheAction<T>(string actionPath) where T : SteamVR_Action, new()
		{
			return null;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000028AC File Offset: 0x00000AAC
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x3074050", Offset = "0x3072650", VA = "0x183074050")]
		private static bool VRTryGetActionActiveAnyState(InputSystem.Action button, out float result)
		{
			return default(bool);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000028C4 File Offset: 0x00000AC4
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x30740F0", Offset = "0x30726F0", VA = "0x1830740F0")]
		private static float VRGetButtonDownTimeCached(InputSystem.Action button)
		{
			return 0f;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000028DC File Offset: 0x00000ADC
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x3074170", Offset = "0x3072770", VA = "0x183074170")]
		private static float VRGetActionDownTime(InputSystem.Action button)
		{
			return 0f;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000028F4 File Offset: 0x00000AF4
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
		private static bool VrEnabled()
		{
			return default(bool);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x30741F0", Offset = "0x30727F0", VA = "0x1830741F0")]
		private static GameObject VRGetActionSourceAnyState(InputSystem.Action button)
		{
			return null;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000290C File Offset: 0x00000B0C
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x3074270", Offset = "0x3072870", VA = "0x183074270")]
		private static bool VRGetActionActiveAnyState(InputSystem.Action button, InputSystem.VRActionState vrActionState = InputSystem.VRActionState.Active)
		{
			return default(bool);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x30742F0", Offset = "0x30728F0", VA = "0x1830742F0")]
		private static GameObject VRGetButtonSource(InputSystem.Action button)
		{
			return null;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002924 File Offset: 0x00000B24
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x3074330", Offset = "0x3072930", VA = "0x183074330")]
		private static bool VRGetButton(InputSystem.Action button)
		{
			return default(bool);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000293C File Offset: 0x00000B3C
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x3074370", Offset = "0x3072970", VA = "0x183074370")]
		private static bool VRGetButtonUp(InputSystem.Action button)
		{
			return default(bool);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002954 File Offset: 0x00000B54
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x30743B0", Offset = "0x30729B0", VA = "0x1830743B0")]
		private static float VRGetButtonDownTime(InputSystem.Action button)
		{
			return 0f;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000296C File Offset: 0x00000B6C
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x30743F0", Offset = "0x30729F0", VA = "0x1830743F0")]
		private static bool VRGetButtonDown(InputSystem.Action button)
		{
			return default(bool);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002984 File Offset: 0x00000B84
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x3074430", Offset = "0x3072A30", VA = "0x183074430")]
		private static bool VRTryGetAxis(InputSystem.Action button, out float result)
		{
			return default(bool);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000299C File Offset: 0x00000B9C
		[Token(Token = "0x1700001B")]
		public static InputSystem.Action VRThrowInput
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x3074480", Offset = "0x3072A80", VA = "0x183074480")]
			get
			{
				return default(InputSystem.Action);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000029B4 File Offset: 0x00000BB4
		[Token(Token = "0x1700001C")]
		public static InputSystem.Action VRArrowDrawInput
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x30744E0", Offset = "0x3072AE0", VA = "0x1830744E0")]
			get
			{
				return default(InputSystem.Action);
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x7951A0", Offset = "0x7937A0", VA = "0x1807951A0")]
		public InputSystem()
		{
		}

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<InputSystem.VRAction> _vrActions;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		private const string InputCustomBindingSettingKey = "Input.CustomBinding";

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static float _delayedActionStartTime;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static float _delayFillBarStart;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static float _delayedActionPercent;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static float _delayedActionFill;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool _delayedActionIsDown;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private static bool _delayedActionWasUpdated;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static InputSystem.Action _delayedAction;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private static bool InMenuScene;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Dictionary<InputState, bool> States;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static SonsInputMapping _sonsInputMapping;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static bool _userInputBindingLoaded;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static Dictionary<string, InputAction> _cachedInputMappings;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static Dictionary<int, InputAction> _cachedStateInputMappings;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		private const string UserBindingsFilepath = "bindings.input";

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static Dictionary<InputState, InputActionMap> _maps;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _showCursorOnEditorFocusLost;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static InputSystem.SoftwareCursor _cursor;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static Dictionary<string, SteamVR_Action> _cachedActions;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static Dictionary<InputSystem.Action, Dictionary<string, string>> _cachedActionPaths;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static Dictionary<SteamVR_ActionSet, int> _actionSetActivatedFrameCount;

		// Token: 0x0200000F RID: 15
		[Token(Token = "0x200000F")]
		public struct Action : IEquatable<InputSystem.Action>
		{
			// Token: 0x060000FE RID: 254 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x30768F0", Offset = "0x3074EF0", VA = "0x1830768F0")]
			public Action(string name, InputSystem.ActionId actionId)
			{
			}

			// Token: 0x060000FF RID: 255 RVA: 0x000029CC File Offset: 0x00000BCC
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x3076A30", Offset = "0x3075030", VA = "0x183076A30")]
			public bool Matches(string name)
			{
				return default(bool);
			}

			// Token: 0x06000100 RID: 256 RVA: 0x000029E4 File Offset: 0x00000BE4
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x3076AC0", Offset = "0x30750C0", VA = "0x183076AC0")]
			public bool Matches(InputSystem.ActionId actionEnum)
			{
				return default(bool);
			}

			// Token: 0x06000101 RID: 257 RVA: 0x000029FC File Offset: 0x00000BFC
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x3076B40", Offset = "0x3075140", VA = "0x183076B40", Slot = "4")]
			public bool Equals(InputSystem.Action other)
			{
				return default(bool);
			}

			// Token: 0x06000102 RID: 258 RVA: 0x00002A14 File Offset: 0x00000C14
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x3076B60", Offset = "0x3075160", VA = "0x183076B60", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x06000103 RID: 259 RVA: 0x00002A2C File Offset: 0x00000C2C
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x3076C00", Offset = "0x3075200", VA = "0x183076C00")]
			public static bool operator ==(InputSystem.Action action1, InputSystem.Action action2)
			{
				return default(bool);
			}

			// Token: 0x06000104 RID: 260 RVA: 0x00002A44 File Offset: 0x00000C44
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x3076C30", Offset = "0x3075230", VA = "0x183076C30")]
			public static bool operator !=(InputSystem.Action action1, InputSystem.Action action2)
			{
				return default(bool);
			}

			// Token: 0x06000105 RID: 261 RVA: 0x00002A5C File Offset: 0x00000C5C
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x3076C70", Offset = "0x3075270", VA = "0x183076C70", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x06000106 RID: 262 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x633720", Offset = "0x631D20", VA = "0x180633720")]
			public static explicit operator string(InputSystem.Action action)
			{
				return null;
			}

			// Token: 0x06000107 RID: 263 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x633720", Offset = "0x631D20", VA = "0x180633720")]
			public string GetName()
			{
				return null;
			}

			// Token: 0x06000108 RID: 264 RVA: 0x00002A74 File Offset: 0x00000C74
			[Token(Token = "0x6000108")]
			[Address(RVA = "0xD96410", Offset = "0xD94A10", VA = "0x180D96410")]
			public int GetNameHash()
			{
				return 0;
			}

			// Token: 0x06000109 RID: 265 RVA: 0x00002A8C File Offset: 0x00000C8C
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x3076C80", Offset = "0x3075280", VA = "0x183076C80")]
			public static int GetHashFromName(string actionName)
			{
				return 0;
			}

			// Token: 0x0600010A RID: 266 RVA: 0x00002AA4 File Offset: 0x00000CA4
			[Token(Token = "0x600010A")]
			[Address(RVA = "0xF9ACD0", Offset = "0xF992D0", VA = "0x180F9ACD0")]
			public InputSystem.ActionId GetActionId()
			{
				return InputSystem.ActionId.Inventory;
			}

			// Token: 0x04000065 RID: 101
			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly string _name;

			// Token: 0x04000066 RID: 102
			[Token(Token = "0x4000066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly InputSystem.ActionId _actionId;

			// Token: 0x04000067 RID: 103
			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private readonly int _nameHash;
		}

		// Token: 0x02000010 RID: 16
		[Token(Token = "0x2000010")]
		public enum ActionId
		{
			// Token: 0x04000069 RID: 105
			[Token(Token = "0x4000069")]
			None = -1,
			// Token: 0x0400006A RID: 106
			[Token(Token = "0x400006A")]
			Inventory,
			// Token: 0x0400006B RID: 107
			[Token(Token = "0x400006B")]
			Book,
			// Token: 0x0400006C RID: 108
			[Token(Token = "0x400006C")]
			Horizontal,
			// Token: 0x0400006D RID: 109
			[Token(Token = "0x400006D")]
			Right,
			// Token: 0x0400006E RID: 110
			[Token(Token = "0x400006E")]
			Left,
			// Token: 0x0400006F RID: 111
			[Token(Token = "0x400006F")]
			Vertical,
			// Token: 0x04000070 RID: 112
			[Token(Token = "0x4000070")]
			Up,
			// Token: 0x04000071 RID: 113
			[Token(Token = "0x4000071")]
			Down,
			// Token: 0x04000072 RID: 114
			[Token(Token = "0x4000072")]
			Jump,
			// Token: 0x04000073 RID: 115
			[Token(Token = "0x4000073")]
			MouseX,
			// Token: 0x04000074 RID: 116
			[Token(Token = "0x4000074")]
			LookRight,
			// Token: 0x04000075 RID: 117
			[Token(Token = "0x4000075")]
			LookLeft,
			// Token: 0x04000076 RID: 118
			[Token(Token = "0x4000076")]
			MouseY,
			// Token: 0x04000077 RID: 119
			[Token(Token = "0x4000077")]
			LookUp,
			// Token: 0x04000078 RID: 120
			[Token(Token = "0x4000078")]
			LookDown,
			// Token: 0x04000079 RID: 121
			[Token(Token = "0x4000079")]
			Run,
			// Token: 0x0400007A RID: 122
			[Token(Token = "0x400007A")]
			Crouch,
			// Token: 0x0400007B RID: 123
			[Token(Token = "0x400007B")]
			PrimaryAction,
			// Token: 0x0400007C RID: 124
			[Token(Token = "0x400007C")]
			SecondaryAction,
			// Token: 0x0400007D RID: 125
			[Token(Token = "0x400007D")]
			Take,
			// Token: 0x0400007E RID: 126
			[Token(Token = "0x400007E")]
			Drop,
			// Token: 0x0400007F RID: 127
			[Token(Token = "0x400007F")]
			RestKey,
			// Token: 0x04000080 RID: 128
			[Token(Token = "0x4000080")]
			Save,
			// Token: 0x04000081 RID: 129
			[Token(Token = "0x4000081")]
			Lighter,
			// Token: 0x04000082 RID: 130
			[Token(Token = "0x4000082")]
			Craft,
			// Token: 0x04000083 RID: 131
			[Token(Token = "0x4000083")]
			Utility,
			// Token: 0x04000084 RID: 132
			[Token(Token = "0x4000084")]
			WalkyTalky,
			// Token: 0x04000085 RID: 133
			[Token(Token = "0x4000085")]
			Rotate,
			// Token: 0x04000086 RID: 134
			[Token(Token = "0x4000086")]
			Batch,
			// Token: 0x04000087 RID: 135
			[Token(Token = "0x4000087")]
			OpenChat,
			// Token: 0x04000088 RID: 136
			[Token(Token = "0x4000088")]
			Submit,
			// Token: 0x04000089 RID: 137
			[Token(Token = "0x4000089")]
			Esc,
			// Token: 0x0400008A RID: 138
			[Token(Token = "0x400008A")]
			Build,
			// Token: 0x0400008B RID: 139
			[Token(Token = "0x400008B")]
			InteractWithItem,
			// Token: 0x0400008C RID: 140
			[Token(Token = "0x400008C")]
			AlternateInteractWithItem,
			// Token: 0x0400008D RID: 141
			[Token(Token = "0x400008D")]
			PreviousChapter,
			// Token: 0x0400008E RID: 142
			[Token(Token = "0x400008E")]
			NextChapter,
			// Token: 0x0400008F RID: 143
			[Token(Token = "0x400008F")]
			PreviousPage,
			// Token: 0x04000090 RID: 144
			[Token(Token = "0x4000090")]
			NextPage,
			// Token: 0x04000091 RID: 145
			[Token(Token = "0x4000091")]
			Back,
			// Token: 0x04000092 RID: 146
			[Token(Token = "0x4000092")]
			Map,
			// Token: 0x04000093 RID: 147
			[Token(Token = "0x4000093")]
			ScrollY,
			// Token: 0x04000094 RID: 148
			[Token(Token = "0x4000094")]
			HotKey1,
			// Token: 0x04000095 RID: 149
			[Token(Token = "0x4000095")]
			HotKey2,
			// Token: 0x04000096 RID: 150
			[Token(Token = "0x4000096")]
			HotKey3,
			// Token: 0x04000097 RID: 151
			[Token(Token = "0x4000097")]
			HotKey4,
			// Token: 0x04000098 RID: 152
			[Token(Token = "0x4000098")]
			ScrollX,
			// Token: 0x04000099 RID: 153
			[Token(Token = "0x4000099")]
			Rebind,
			// Token: 0x0400009A RID: 154
			[Token(Token = "0x400009A")]
			SetOption,
			// Token: 0x0400009B RID: 155
			[Token(Token = "0x400009B")]
			Reset,
			// Token: 0x0400009C RID: 156
			[Token(Token = "0x400009C")]
			SaveBindings,
			// Token: 0x0400009D RID: 157
			[Token(Token = "0x400009D")]
			Skip,
			// Token: 0x0400009E RID: 158
			[Token(Token = "0x400009E")]
			Select,
			// Token: 0x0400009F RID: 159
			[Token(Token = "0x400009F")]
			Walkman,
			// Token: 0x040000A0 RID: 160
			[Token(Token = "0x40000A0")]
			PlayerList,
			// Token: 0x040000A1 RID: 161
			[Token(Token = "0x40000A1")]
			CloseChat,
			// Token: 0x040000A2 RID: 162
			[Token(Token = "0x40000A2")]
			Radial,
			// Token: 0x040000A3 RID: 163
			[Token(Token = "0x40000A3")]
			Debug,
			// Token: 0x040000A4 RID: 164
			[Token(Token = "0x40000A4")]
			MouseScrollWheel,
			// Token: 0x040000A5 RID: 165
			[Token(Token = "0x40000A5")]
			JoyY,
			// Token: 0x040000A6 RID: 166
			[Token(Token = "0x40000A6")]
			JoyX,
			// Token: 0x040000A7 RID: 167
			[Token(Token = "0x40000A7")]
			Interact,
			// Token: 0x040000A8 RID: 168
			[Token(Token = "0x40000A8")]
			CycleForward,
			// Token: 0x040000A9 RID: 169
			[Token(Token = "0x40000A9")]
			CycleBack,
			// Token: 0x040000AA RID: 170
			[Token(Token = "0x40000AA")]
			TogglePauseMenu,
			// Token: 0x040000AB RID: 171
			[Token(Token = "0x40000AB")]
			PlaceElement,
			// Token: 0x040000AC RID: 172
			[Token(Token = "0x40000AC")]
			CutElement,
			// Token: 0x040000AD RID: 173
			[Token(Token = "0x40000AD")]
			RotateElement,
			// Token: 0x040000AE RID: 174
			[Token(Token = "0x40000AE")]
			CancelPlace,
			// Token: 0x040000AF RID: 175
			[Token(Token = "0x40000AF")]
			TogglePlaceMode,
			// Token: 0x040000B0 RID: 176
			[Token(Token = "0x40000B0")]
			DismantleElement,
			// Token: 0x040000B1 RID: 177
			[Token(Token = "0x40000B1")]
			Open,
			// Token: 0x040000B2 RID: 178
			[Token(Token = "0x40000B2")]
			Use,
			// Token: 0x040000B3 RID: 179
			[Token(Token = "0x40000B3")]
			Sleep,
			// Token: 0x040000B4 RID: 180
			[Token(Token = "0x40000B4")]
			QuickSave,
			// Token: 0x040000B5 RID: 181
			[Token(Token = "0x40000B5")]
			QuickLoad,
			// Token: 0x040000B6 RID: 182
			[Token(Token = "0x40000B6")]
			IgniteObject,
			// Token: 0x040000B7 RID: 183
			[Token(Token = "0x40000B7")]
			Confirm,
			// Token: 0x040000B8 RID: 184
			[Token(Token = "0x40000B8")]
			Console,
			// Token: 0x040000B9 RID: 185
			[Token(Token = "0x40000B9")]
			HistoryBack,
			// Token: 0x040000BA RID: 186
			[Token(Token = "0x40000BA")]
			HistoryForward,
			// Token: 0x040000BB RID: 187
			[Token(Token = "0x40000BB")]
			AutoComplete,
			// Token: 0x040000BC RID: 188
			[Token(Token = "0x40000BC")]
			DebugOverlay,
			// Token: 0x040000BD RID: 189
			[Token(Token = "0x40000BD")]
			DebugPlayerStats,
			// Token: 0x040000BE RID: 190
			[Token(Token = "0x40000BE")]
			DebugVailStats,
			// Token: 0x040000BF RID: 191
			[Token(Token = "0x40000BF")]
			DebugVailCamera,
			// Token: 0x040000C0 RID: 192
			[Token(Token = "0x40000C0")]
			DebugBreak,
			// Token: 0x040000C1 RID: 193
			[Token(Token = "0x40000C1")]
			Reload,
			// Token: 0x040000C2 RID: 194
			[Token(Token = "0x40000C2")]
			RevivePlayer,
			// Token: 0x040000C3 RID: 195
			[Token(Token = "0x40000C3")]
			ShoulderTap,
			// Token: 0x040000C4 RID: 196
			[Token(Token = "0x40000C4")]
			Apply,
			// Token: 0x040000C5 RID: 197
			[Token(Token = "0x40000C5")]
			GpsZoom,
			// Token: 0x040000C6 RID: 198
			[Token(Token = "0x40000C6")]
			CancelModal,
			// Token: 0x040000C7 RID: 199
			[Token(Token = "0x40000C7")]
			ConfirmModal,
			// Token: 0x040000C8 RID: 200
			[Token(Token = "0x40000C8")]
			CancelStructure,
			// Token: 0x040000C9 RID: 201
			[Token(Token = "0x40000C9")]
			GoToBuilding,
			// Token: 0x040000CA RID: 202
			[Token(Token = "0x40000CA")]
			GoToTutorials,
			// Token: 0x040000CB RID: 203
			[Token(Token = "0x40000CB")]
			RotateStructurePositive,
			// Token: 0x040000CC RID: 204
			[Token(Token = "0x40000CC")]
			RotateStructureNegative,
			// Token: 0x040000CD RID: 205
			[Token(Token = "0x40000CD")]
			BookFlipPageNext,
			// Token: 0x040000CE RID: 206
			[Token(Token = "0x40000CE")]
			BookFlipPagePrevious,
			// Token: 0x040000CF RID: 207
			[Token(Token = "0x40000CF")]
			Place,
			// Token: 0x040000D0 RID: 208
			[Token(Token = "0x40000D0")]
			GrabBagCycleCategory,
			// Token: 0x040000D1 RID: 209
			[Token(Token = "0x40000D1")]
			GpsTracker,
			// Token: 0x040000D2 RID: 210
			[Token(Token = "0x40000D2")]
			HotKey5,
			// Token: 0x040000D3 RID: 211
			[Token(Token = "0x40000D3")]
			HotKey6,
			// Token: 0x040000D4 RID: 212
			[Token(Token = "0x40000D4")]
			HotKey7,
			// Token: 0x040000D5 RID: 213
			[Token(Token = "0x40000D5")]
			HotKey8,
			// Token: 0x040000D6 RID: 214
			[Token(Token = "0x40000D6")]
			HotKey9,
			// Token: 0x040000D7 RID: 215
			[Token(Token = "0x40000D7")]
			HotKey0,
			// Token: 0x040000D8 RID: 216
			[Token(Token = "0x40000D8")]
			GrabBagCycleNextCategory,
			// Token: 0x040000D9 RID: 217
			[Token(Token = "0x40000D9")]
			GrabBagCyclePreviousCategory,
			// Token: 0x040000DA RID: 218
			[Token(Token = "0x40000DA")]
			AddIngredient,
			// Token: 0x040000DB RID: 219
			[Token(Token = "0x40000DB")]
			Throttle,
			// Token: 0x040000DC RID: 220
			[Token(Token = "0x40000DC")]
			Reverse,
			// Token: 0x040000DD RID: 221
			[Token(Token = "0x40000DD")]
			TurnLeft,
			// Token: 0x040000DE RID: 222
			[Token(Token = "0x40000DE")]
			TurnRight,
			// Token: 0x040000DF RID: 223
			[Token(Token = "0x40000DF")]
			Boost,
			// Token: 0x040000E0 RID: 224
			[Token(Token = "0x40000E0")]
			HandBrake
		}

		// Token: 0x02000011 RID: 17
		[Token(Token = "0x2000011")]
		public static class Actions
		{
			// Token: 0x0600010B RID: 267 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x3076D00", Offset = "0x3075300", VA = "0x183076D00")]
			public static List<string> GetMenuDropdown()
			{
				return null;
			}

			// Token: 0x0600010C RID: 268 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x3076EC0", Offset = "0x30754C0", VA = "0x183076EC0")]
			public static void Register(InputSystem.Action action)
			{
			}

			// Token: 0x0600010D RID: 269 RVA: 0x00002ABC File Offset: 0x00000CBC
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x30774A0", Offset = "0x3075AA0", VA = "0x1830774A0")]
			public static InputSystem.Action Find(string actionName)
			{
				return default(InputSystem.Action);
			}

			// Token: 0x0600010E RID: 270 RVA: 0x00002AD4 File Offset: 0x00000CD4
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x3077670", Offset = "0x3075C70", VA = "0x183077670")]
			public static InputSystem.Action Find(InputSystem.ActionId actionEnum)
			{
				return default(InputSystem.Action);
			}

			// Token: 0x040000E1 RID: 225
			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Dictionary<int, InputSystem.Action> _actionsByName;

			// Token: 0x040000E2 RID: 226
			[Token(Token = "0x40000E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static Dictionary<InputSystem.ActionId, InputSystem.Action> _actionsByActionId;

			// Token: 0x040000E3 RID: 227
			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static List<InputSystem.Action> _allActions;

			// Token: 0x040000E4 RID: 228
			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static readonly InputSystem.Action None;

			// Token: 0x040000E5 RID: 229
			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static readonly InputSystem.Action MouseX;

			// Token: 0x040000E6 RID: 230
			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static readonly InputSystem.Action MouseY;

			// Token: 0x040000E7 RID: 231
			[Token(Token = "0x40000E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static readonly InputSystem.Action JoyX;

			// Token: 0x040000E8 RID: 232
			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static readonly InputSystem.Action JoyY;

			// Token: 0x040000E9 RID: 233
			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static readonly InputSystem.Action ScrollY;

			// Token: 0x040000EA RID: 234
			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static readonly InputSystem.Action ScrollX;

			// Token: 0x040000EB RID: 235
			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public static readonly InputSystem.Action Right;

			// Token: 0x040000EC RID: 236
			[Token(Token = "0x40000EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public static readonly InputSystem.Action Left;

			// Token: 0x040000ED RID: 237
			[Token(Token = "0x40000ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public static readonly InputSystem.Action Up;

			// Token: 0x040000EE RID: 238
			[Token(Token = "0x40000EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public static readonly InputSystem.Action Down;

			// Token: 0x040000EF RID: 239
			[Token(Token = "0x40000EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public static readonly InputSystem.Action LookLeft;

			// Token: 0x040000F0 RID: 240
			[Token(Token = "0x40000F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			public static readonly InputSystem.Action LookRight;

			// Token: 0x040000F1 RID: 241
			[Token(Token = "0x40000F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			public static readonly InputSystem.Action LookUp;

			// Token: 0x040000F2 RID: 242
			[Token(Token = "0x40000F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			public static readonly InputSystem.Action LookDown;

			// Token: 0x040000F3 RID: 243
			[Token(Token = "0x40000F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			public static readonly InputSystem.Action Esc;

			// Token: 0x040000F4 RID: 244
			[Token(Token = "0x40000F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			public static readonly InputSystem.Action Select;

			// Token: 0x040000F5 RID: 245
			[Token(Token = "0x40000F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			public static readonly InputSystem.Action Submit;

			// Token: 0x040000F6 RID: 246
			[Token(Token = "0x40000F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			public static readonly InputSystem.Action HistoryBack;

			// Token: 0x040000F7 RID: 247
			[Token(Token = "0x40000F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			public static readonly InputSystem.Action HistoryForward;

			// Token: 0x040000F8 RID: 248
			[Token(Token = "0x40000F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			public static readonly InputSystem.Action AutoComplete;

			// Token: 0x040000F9 RID: 249
			[Token(Token = "0x40000F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			public static readonly InputSystem.Action DebugOverlay;

			// Token: 0x040000FA RID: 250
			[Token(Token = "0x40000FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			public static readonly InputSystem.Action DebugPlayerStats;

			// Token: 0x040000FB RID: 251
			[Token(Token = "0x40000FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			public static readonly InputSystem.Action DebugVailStats;

			// Token: 0x040000FC RID: 252
			[Token(Token = "0x40000FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			public static readonly InputSystem.Action DebugVailCamera;

			// Token: 0x040000FD RID: 253
			[Token(Token = "0x40000FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			public static readonly InputSystem.Action DebugBreak;

			// Token: 0x040000FE RID: 254
			[Token(Token = "0x40000FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			public static readonly InputSystem.Action Console;

			// Token: 0x040000FF RID: 255
			[Token(Token = "0x40000FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			public static readonly InputSystem.Action Skip;

			// Token: 0x04000100 RID: 256
			[Token(Token = "0x4000100")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			public static readonly InputSystem.Action SetOption;

			// Token: 0x04000101 RID: 257
			[Token(Token = "0x4000101")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			public static readonly InputSystem.Action CycleBack;

			// Token: 0x04000102 RID: 258
			[Token(Token = "0x4000102")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			public static readonly InputSystem.Action CycleForward;

			// Token: 0x04000103 RID: 259
			[Token(Token = "0x4000103")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			public static readonly InputSystem.Action Back;

			// Token: 0x04000104 RID: 260
			[Token(Token = "0x4000104")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			public static readonly InputSystem.Action Confirm;

			// Token: 0x04000105 RID: 261
			[Token(Token = "0x4000105")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
			public static readonly InputSystem.Action Apply;

			// Token: 0x04000106 RID: 262
			[Token(Token = "0x4000106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
			public static readonly InputSystem.Action Reset;

			// Token: 0x04000107 RID: 263
			[Token(Token = "0x4000107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
			public static readonly InputSystem.Action Batch;

			// Token: 0x04000108 RID: 264
			[Token(Token = "0x4000108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
			public static readonly InputSystem.Action PrimaryAction;

			// Token: 0x04000109 RID: 265
			[Token(Token = "0x4000109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
			public static readonly InputSystem.Action SecondaryAction;

			// Token: 0x0400010A RID: 266
			[Token(Token = "0x400010A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
			public static readonly InputSystem.Action Vertical;

			// Token: 0x0400010B RID: 267
			[Token(Token = "0x400010B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
			public static readonly InputSystem.Action Horizontal;

			// Token: 0x0400010C RID: 268
			[Token(Token = "0x400010C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
			public static readonly InputSystem.Action Run;

			// Token: 0x0400010D RID: 269
			[Token(Token = "0x400010D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
			public static readonly InputSystem.Action Take;

			// Token: 0x0400010E RID: 270
			[Token(Token = "0x400010E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
			public static readonly InputSystem.Action Interact;

			// Token: 0x0400010F RID: 271
			[Token(Token = "0x400010F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
			public static readonly InputSystem.Action Place;

			// Token: 0x04000110 RID: 272
			[Token(Token = "0x4000110")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
			public static readonly InputSystem.Action Drop;

			// Token: 0x04000111 RID: 273
			[Token(Token = "0x4000111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
			public static readonly InputSystem.Action Crouch;

			// Token: 0x04000112 RID: 274
			[Token(Token = "0x4000112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
			public static readonly InputSystem.Action Jump;

			// Token: 0x04000113 RID: 275
			[Token(Token = "0x4000113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
			public static readonly InputSystem.Action Craft;

			// Token: 0x04000114 RID: 276
			[Token(Token = "0x4000114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
			public static readonly InputSystem.Action Build;

			// Token: 0x04000115 RID: 277
			[Token(Token = "0x4000115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
			public static readonly InputSystem.Action Reload;

			// Token: 0x04000116 RID: 278
			[Token(Token = "0x4000116")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
			public static readonly InputSystem.Action Open;

			// Token: 0x04000117 RID: 279
			[Token(Token = "0x4000117")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
			public static readonly InputSystem.Action Use;

			// Token: 0x04000118 RID: 280
			[Token(Token = "0x4000118")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
			public static readonly InputSystem.Action Sleep;

			// Token: 0x04000119 RID: 281
			[Token(Token = "0x4000119")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
			public static readonly InputSystem.Action RevivePlayer;

			// Token: 0x0400011A RID: 282
			[Token(Token = "0x400011A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
			public static readonly InputSystem.Action ShoulderTap;

			// Token: 0x0400011B RID: 283
			[Token(Token = "0x400011B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
			public static readonly InputSystem.Action ConfirmModal;

			// Token: 0x0400011C RID: 284
			[Token(Token = "0x400011C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
			public static readonly InputSystem.Action CancelModal;

			// Token: 0x0400011D RID: 285
			[Token(Token = "0x400011D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
			public static readonly InputSystem.Action CancelStructure;

			// Token: 0x0400011E RID: 286
			[Token(Token = "0x400011E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
			public static readonly InputSystem.Action AddIngredient;

			// Token: 0x0400011F RID: 287
			[Token(Token = "0x400011F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
			public static readonly InputSystem.Action GoToBuilding;

			// Token: 0x04000120 RID: 288
			[Token(Token = "0x4000120")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
			public static readonly InputSystem.Action GoToTutorials;

			// Token: 0x04000121 RID: 289
			[Token(Token = "0x4000121")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
			public static readonly InputSystem.Action RotateStructurePositive;

			// Token: 0x04000122 RID: 290
			[Token(Token = "0x4000122")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
			public static readonly InputSystem.Action RotateStructureNegative;

			// Token: 0x04000123 RID: 291
			[Token(Token = "0x4000123")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
			public static readonly InputSystem.Action TogglePauseMenu;

			// Token: 0x04000124 RID: 292
			[Token(Token = "0x4000124")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
			public static readonly InputSystem.Action Inventory;

			// Token: 0x04000125 RID: 293
			[Token(Token = "0x4000125")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
			public static readonly InputSystem.Action PreviousChapter;

			// Token: 0x04000126 RID: 294
			[Token(Token = "0x4000126")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
			public static readonly InputSystem.Action NextChapter;

			// Token: 0x04000127 RID: 295
			[Token(Token = "0x4000127")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
			public static readonly InputSystem.Action PreviousPage;

			// Token: 0x04000128 RID: 296
			[Token(Token = "0x4000128")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
			public static readonly InputSystem.Action NextPage;

			// Token: 0x04000129 RID: 297
			[Token(Token = "0x4000129")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
			public static readonly InputSystem.Action Utility;

			// Token: 0x0400012A RID: 298
			[Token(Token = "0x400012A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
			public static readonly InputSystem.Action Walkman;

			// Token: 0x0400012B RID: 299
			[Token(Token = "0x400012B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
			public static readonly InputSystem.Action WalkyTalky;

			// Token: 0x0400012C RID: 300
			[Token(Token = "0x400012C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
			public static readonly InputSystem.Action GpsTracker;

			// Token: 0x0400012D RID: 301
			[Token(Token = "0x400012D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
			public static readonly InputSystem.Action Map;

			// Token: 0x0400012E RID: 302
			[Token(Token = "0x400012E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
			public static readonly InputSystem.Action Lighter;

			// Token: 0x0400012F RID: 303
			[Token(Token = "0x400012F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
			public static readonly InputSystem.Action IgniteObject;

			// Token: 0x04000130 RID: 304
			[Token(Token = "0x4000130")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
			public static readonly InputSystem.Action Save;

			// Token: 0x04000131 RID: 305
			[Token(Token = "0x4000131")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
			public static readonly InputSystem.Action RestKey;

			// Token: 0x04000132 RID: 306
			[Token(Token = "0x4000132")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
			public static readonly InputSystem.Action Rotate;

			// Token: 0x04000133 RID: 307
			[Token(Token = "0x4000133")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x508")]
			public static readonly InputSystem.Action PlayerList;

			// Token: 0x04000134 RID: 308
			[Token(Token = "0x4000134")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x518")]
			public static readonly InputSystem.Action OpenChat;

			// Token: 0x04000135 RID: 309
			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x528")]
			public static readonly InputSystem.Action CloseChat;

			// Token: 0x04000136 RID: 310
			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x538")]
			public static readonly InputSystem.Action Rebind;

			// Token: 0x04000137 RID: 311
			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x548")]
			public static readonly InputSystem.Action SaveBindings;

			// Token: 0x04000138 RID: 312
			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x558")]
			public static readonly InputSystem.Action HotKey1;

			// Token: 0x04000139 RID: 313
			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x568")]
			public static readonly InputSystem.Action HotKey2;

			// Token: 0x0400013A RID: 314
			[Token(Token = "0x400013A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x578")]
			public static readonly InputSystem.Action HotKey3;

			// Token: 0x0400013B RID: 315
			[Token(Token = "0x400013B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x588")]
			public static readonly InputSystem.Action HotKey4;

			// Token: 0x0400013C RID: 316
			[Token(Token = "0x400013C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x598")]
			public static readonly InputSystem.Action HotKey5;

			// Token: 0x0400013D RID: 317
			[Token(Token = "0x400013D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5A8")]
			public static readonly InputSystem.Action HotKey6;

			// Token: 0x0400013E RID: 318
			[Token(Token = "0x400013E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5B8")]
			public static readonly InputSystem.Action HotKey7;

			// Token: 0x0400013F RID: 319
			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C8")]
			public static readonly InputSystem.Action HotKey8;

			// Token: 0x04000140 RID: 320
			[Token(Token = "0x4000140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5D8")]
			public static readonly InputSystem.Action HotKey9;

			// Token: 0x04000141 RID: 321
			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5E8")]
			public static readonly InputSystem.Action HotKey0;

			// Token: 0x04000142 RID: 322
			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5F8")]
			public static readonly InputSystem.Action PlaceElement;

			// Token: 0x04000143 RID: 323
			[Token(Token = "0x4000143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x608")]
			public static readonly InputSystem.Action CutElement;

			// Token: 0x04000144 RID: 324
			[Token(Token = "0x4000144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x618")]
			public static readonly InputSystem.Action RotateElement;

			// Token: 0x04000145 RID: 325
			[Token(Token = "0x4000145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x628")]
			public static readonly InputSystem.Action CancelPlace;

			// Token: 0x04000146 RID: 326
			[Token(Token = "0x4000146")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x638")]
			public static readonly InputSystem.Action TogglePlaceMode;

			// Token: 0x04000147 RID: 327
			[Token(Token = "0x4000147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x648")]
			public static readonly InputSystem.Action DismantleElement;

			// Token: 0x04000148 RID: 328
			[Token(Token = "0x4000148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x658")]
			public static readonly InputSystem.Action InteractWithItem;

			// Token: 0x04000149 RID: 329
			[Token(Token = "0x4000149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x668")]
			public static readonly InputSystem.Action AlternateInteractWithItem;

			// Token: 0x0400014A RID: 330
			[Token(Token = "0x400014A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x678")]
			public static readonly InputSystem.Action GpsZoom;

			// Token: 0x0400014B RID: 331
			[Token(Token = "0x400014B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x688")]
			public static InputSystem.Action QuickSave;

			// Token: 0x0400014C RID: 332
			[Token(Token = "0x400014C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x698")]
			public static InputSystem.Action QuickLoad;

			// Token: 0x0400014D RID: 333
			[Token(Token = "0x400014D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6A8")]
			public static readonly InputSystem.Action Radial;

			// Token: 0x0400014E RID: 334
			[Token(Token = "0x400014E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6B8")]
			public static readonly InputSystem.Action Book;

			// Token: 0x0400014F RID: 335
			[Token(Token = "0x400014F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C8")]
			public static readonly InputSystem.Action BookFlipPageNext;

			// Token: 0x04000150 RID: 336
			[Token(Token = "0x4000150")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6D8")]
			public static readonly InputSystem.Action BookFlipPagePrevious;

			// Token: 0x04000151 RID: 337
			[Token(Token = "0x4000151")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6E8")]
			public static readonly InputSystem.Action GrabBagCycleCategory;

			// Token: 0x04000152 RID: 338
			[Token(Token = "0x4000152")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6F8")]
			public static readonly InputSystem.Action GrabBagCycleNextCategory;

			// Token: 0x04000153 RID: 339
			[Token(Token = "0x4000153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x708")]
			public static readonly InputSystem.Action GrabBagCyclePreviousCategory;

			// Token: 0x04000154 RID: 340
			[Token(Token = "0x4000154")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x718")]
			public static readonly InputSystem.Action Throttle;

			// Token: 0x04000155 RID: 341
			[Token(Token = "0x4000155")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x728")]
			public static readonly InputSystem.Action Reverse;

			// Token: 0x04000156 RID: 342
			[Token(Token = "0x4000156")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x738")]
			public static readonly InputSystem.Action HandBrake;

			// Token: 0x04000157 RID: 343
			[Token(Token = "0x4000157")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x748")]
			public static readonly InputSystem.Action Boost;

			// Token: 0x04000158 RID: 344
			[Token(Token = "0x4000158")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x758")]
			public static readonly InputSystem.Action TurnLeft;

			// Token: 0x04000159 RID: 345
			[Token(Token = "0x4000159")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x768")]
			public static readonly InputSystem.Action TurnRight;
		}

		// Token: 0x02000013 RID: 19
		[Token(Token = "0x2000013")]
		public class SoftwareCursor
		{
			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000113 RID: 275 RVA: 0x00002AEC File Offset: 0x00000CEC
			// (set) Token: 0x06000114 RID: 276 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700001D")]
			public bool IsEnabled
			{
				[Token(Token = "0x6000113")]
				[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000114")]
				[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000115 RID: 277 RVA: 0x00002B04 File Offset: 0x00000D04
			[Token(Token = "0x1700001E")]
			public Vector3 ScreenSpacePosition
			{
				[Token(Token = "0x6000115")]
				[Address(RVA = "0xAA8B50", Offset = "0xAA7150", VA = "0x180AA8B50")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x06000116 RID: 278 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x307B110", Offset = "0x3079710", VA = "0x18307B110")]
			public void RegisterSetCursorEnabled(InputSystem.SoftwareCursor.OnSetCursorEnabled onSetCursorEnabled)
			{
			}

			// Token: 0x06000117 RID: 279 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x307B1C0", Offset = "0x30797C0", VA = "0x18307B1C0")]
			public void RegisterSetCursorType(InputSystem.SoftwareCursor.OnSetCursorType onSetCursorType)
			{
			}

			// Token: 0x06000118 RID: 280 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x307B270", Offset = "0x3079870", VA = "0x18307B270")]
			public void RegisterSetCursorScreenPosition(InputSystem.SoftwareCursor.OnSetCursorScreenPosition onSetCursorScreenPosition)
			{
			}

			// Token: 0x06000119 RID: 281 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x307B320", Offset = "0x3079920", VA = "0x18307B320")]
			public void Enable(bool enable, bool useHardwareCursor = true)
			{
			}

			// Token: 0x0600011A RID: 282 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x307B3F0", Offset = "0x30799F0", VA = "0x18307B3F0")]
			public void RefreshCursorVisibility()
			{
			}

			// Token: 0x0600011B RID: 283 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x307B550", Offset = "0x3079B50", VA = "0x18307B550")]
			public void SetType(InputSystem.SoftwareCursor.Types type)
			{
			}

			// Token: 0x0600011C RID: 284 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x307B5F0", Offset = "0x3079BF0", VA = "0x18307B5F0")]
			public void SetScreenPosition(Vector3 screenPosition)
			{
			}

			// Token: 0x0600011D RID: 285 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x307B690", Offset = "0x3079C90", VA = "0x18307B690")]
			public void Reset()
			{
			}

			// Token: 0x0600011E RID: 286 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x307B7F0", Offset = "0x3079DF0", VA = "0x18307B7F0")]
			public SoftwareCursor()
			{
			}

			// Token: 0x0400015D RID: 349
			[Token(Token = "0x400015D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private Vector3 _screenSpacePosition;

			// Token: 0x0400015E RID: 350
			[Token(Token = "0x400015E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static InputSystem.SoftwareCursor.Types _cursorType;

			// Token: 0x0400015F RID: 351
			[Token(Token = "0x400015F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private static bool _useSoftwareCursor;

			// Token: 0x04000160 RID: 352
			[Token(Token = "0x4000160")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static InputSystem.SoftwareCursor.OnSetCursorType _onSetCursorType;

			// Token: 0x04000161 RID: 353
			[Token(Token = "0x4000161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static InputSystem.SoftwareCursor.OnSetCursorEnabled _onSetCursorEnabled;

			// Token: 0x04000162 RID: 354
			[Token(Token = "0x4000162")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static InputSystem.SoftwareCursor.OnSetCursorScreenPosition _onSetCursorScreenPosition;

			// Token: 0x02000014 RID: 20
			[Token(Token = "0x2000014")]
			public enum Types
			{
				// Token: 0x04000164 RID: 356
				[Token(Token = "0x4000164")]
				None,
				// Token: 0x04000165 RID: 357
				[Token(Token = "0x4000165")]
				Arrow,
				// Token: 0x04000166 RID: 358
				[Token(Token = "0x4000166")]
				Hand,
				// Token: 0x04000167 RID: 359
				[Token(Token = "0x4000167")]
				Inventory,
				// Token: 0x04000168 RID: 360
				[Token(Token = "0x4000168")]
				InventoryHover
			}

			// Token: 0x02000015 RID: 21
			// (Invoke) Token: 0x06000121 RID: 289
			[Token(Token = "0x2000015")]
			public delegate void OnSetCursorType(InputSystem.SoftwareCursor.Types type);

			// Token: 0x02000016 RID: 22
			// (Invoke) Token: 0x06000125 RID: 293
			[Token(Token = "0x2000016")]
			public delegate void OnSetCursorEnabled(bool enabled);

			// Token: 0x02000017 RID: 23
			// (Invoke) Token: 0x06000129 RID: 297
			[Token(Token = "0x2000017")]
			public delegate void OnSetCursorScreenPosition(Vector3 screenPosition);
		}

		// Token: 0x02000018 RID: 24
		[Token(Token = "0x2000018")]
		public enum SampleActionType
		{
			// Token: 0x0400016A RID: 362
			[Token(Token = "0x400016A")]
			Button,
			// Token: 0x0400016B RID: 363
			[Token(Token = "0x400016B")]
			ButtonAsAxis,
			// Token: 0x0400016C RID: 364
			[Token(Token = "0x400016C")]
			Vector1,
			// Token: 0x0400016D RID: 365
			[Token(Token = "0x400016D")]
			Vector2,
			// Token: 0x0400016E RID: 366
			[Token(Token = "0x400016E")]
			Vector1Split,
			// Token: 0x0400016F RID: 367
			[Token(Token = "0x400016F")]
			Vector2OnlyX,
			// Token: 0x04000170 RID: 368
			[Token(Token = "0x4000170")]
			Vector2OnlyY
		}

		// Token: 0x02000019 RID: 25
		[Token(Token = "0x2000019")]
		public enum VRActionState
		{
			// Token: 0x04000172 RID: 370
			[Token(Token = "0x4000172")]
			Active,
			// Token: 0x04000173 RID: 371
			[Token(Token = "0x4000173")]
			Up,
			// Token: 0x04000174 RID: 372
			[Token(Token = "0x4000174")]
			Down
		}

		// Token: 0x0200001A RID: 26
		[Token(Token = "0x200001A")]
		public class VRAction
		{
			// Token: 0x0600012C RID: 300 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x307BA10", Offset = "0x307A010", VA = "0x18307BA10")]
			public VRAction(InputSystem.Action actionSource, InputSystem.SampleActionType sampleActionType, KeyMapCategory keyMapCategory)
			{
			}

			// Token: 0x0600012D RID: 301 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x307BA80", Offset = "0x307A080", VA = "0x18307BA80")]
			private void BuildPaths()
			{
			}

			// Token: 0x0600012E RID: 302 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x307BCD0", Offset = "0x307A2D0", VA = "0x18307BCD0")]
			private string VRSanitizeActionName()
			{
				return null;
			}

			// Token: 0x0600012F RID: 303 RVA: 0x00002B1C File Offset: 0x00000D1C
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x307BF20", Offset = "0x307A520", VA = "0x18307BF20")]
			public bool Matches(InputSystem.Action button)
			{
				return default(bool);
			}

			// Token: 0x06000130 RID: 304 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000130")]
			public List<T> GetSteamVRActions<T>() where T : SteamVR_Action, new()
			{
				return null;
			}

			// Token: 0x06000131 RID: 305 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x307BF50", Offset = "0x307A550", VA = "0x18307BF50")]
			public GameObject GetSource()
			{
				return null;
			}

			// Token: 0x06000132 RID: 306 RVA: 0x00002B34 File Offset: 0x00000D34
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x307C040", Offset = "0x307A640", VA = "0x18307C040")]
			public bool Matches(InputSystem.VRActionState state)
			{
				return default(bool);
			}

			// Token: 0x06000133 RID: 307 RVA: 0x00002B4C File Offset: 0x00000D4C
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x307C090", Offset = "0x307A690", VA = "0x18307C090")]
			private bool ButtonMatches(InputSystem.VRActionState state)
			{
				return default(bool);
			}

			// Token: 0x06000134 RID: 308 RVA: 0x00002B64 File Offset: 0x00000D64
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x307C0D0", Offset = "0x307A6D0", VA = "0x18307C0D0")]
			private bool ButtonMatches(string actionPath, InputSystem.VRActionState state)
			{
				return default(bool);
			}

			// Token: 0x06000135 RID: 309 RVA: 0x00002B7C File Offset: 0x00000D7C
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x307C160", Offset = "0x307A760", VA = "0x18307C160")]
			private bool ButtonMatches(InputSystem.VRActionState state, SteamVR_Action_Boolean foundAction)
			{
				return default(bool);
			}

			// Token: 0x06000136 RID: 310 RVA: 0x00002B94 File Offset: 0x00000D94
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x307C470", Offset = "0x307AA70", VA = "0x18307C470")]
			public float GetButtonDownTime()
			{
				return 0f;
			}

			// Token: 0x06000137 RID: 311 RVA: 0x00002BAC File Offset: 0x00000DAC
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
			public float GetButtonDownTimeCached()
			{
				return 0f;
			}

			// Token: 0x06000138 RID: 312 RVA: 0x00002BC4 File Offset: 0x00000DC4
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x301B1A0", Offset = "0x30197A0", VA = "0x18301B1A0")]
			public bool Matches(InputSystem.SampleActionType button)
			{
				return default(bool);
			}

			// Token: 0x06000139 RID: 313 RVA: 0x00002BDC File Offset: 0x00000DDC
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x307C5D0", Offset = "0x307ABD0", VA = "0x18307C5D0")]
			public float GetVectorAxis()
			{
				return 0f;
			}

			// Token: 0x0600013A RID: 314 RVA: 0x00002BF4 File Offset: 0x00000DF4
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x307CC40", Offset = "0x307B240", VA = "0x18307CC40")]
			private static float TrimMinResults(float result)
			{
				return 0f;
			}

			// Token: 0x0600013B RID: 315 RVA: 0x00002C0C File Offset: 0x00000E0C
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x307CC60", Offset = "0x307B260", VA = "0x18307CC60")]
			public bool IsActive()
			{
				return default(bool);
			}

			// Token: 0x04000175 RID: 373
			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private InputSystem.Action _actionSource;

			// Token: 0x04000176 RID: 374
			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private InputSystem.SampleActionType _sampleActionType;

			// Token: 0x04000177 RID: 375
			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private KeyMapCategory _keyMapCategory;

			// Token: 0x04000178 RID: 376
			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string[] _paths;

			// Token: 0x04000179 RID: 377
			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float _buttonDownTimeCache;
		}
	}
}
