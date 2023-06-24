using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Gui.Input;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x020007EF RID: 2031
	[Token(Token = "0x20007EF")]
	[AddComponentMenu("Sons/Gameplay/SleepInteract")]
	public class SleepInteract : MonoBehaviour
	{
		// Token: 0x060036E9 RID: 14057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E9")]
		[Address(RVA = "0x35357C0", Offset = "0x3533DC0", VA = "0x1835357C0")]
		private void Awake()
		{
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036EA")]
		[Address(RVA = "0x3535940", Offset = "0x3533F40", VA = "0x183535940")]
		private void Update()
		{
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x000106E0 File Offset: 0x0000E8E0
		[Token(Token = "0x60036EB")]
		[Address(RVA = "0x3535C00", Offset = "0x3534200", VA = "0x183535C00")]
		private bool IsInteractionAllowed()
		{
			return default(bool);
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036EC")]
		[Address(RVA = "0x3535C40", Offset = "0x3534240", VA = "0x183535C40")]
		private void OnDisable()
		{
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036ED")]
		[Address(RVA = "0x3535E10", Offset = "0x3534410", VA = "0x183535E10")]
		private void OnDestroy()
		{
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036EE")]
		[Address(RVA = "0x3535E70", Offset = "0x3534470", VA = "0x183535E70")]
		private void OnValidate()
		{
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036EF")]
		[Address(RVA = "0x3535F50", Offset = "0x3534550", VA = "0x183535F50")]
		private void UpdateSinglePlayerSleep()
		{
		}

		// Token: 0x060036F0 RID: 14064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F0")]
		[Address(RVA = "0x3536010", Offset = "0x3534610", VA = "0x183536010")]
		private void UpdateMultiplayerSleep()
		{
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F1")]
		[Address(RVA = "0x35366C0", Offset = "0x3534CC0", VA = "0x1835366C0")]
		private void IsWaitingToSleep(bool isWaiting)
		{
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F2")]
		[Address(RVA = "0x35367D0", Offset = "0x3534DD0", VA = "0x1835367D0")]
		private void OnGrabExit()
		{
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F3")]
		[Address(RVA = "0x3536870", Offset = "0x3534E70", VA = "0x183536870")]
		private void SetShowIcon(bool sleepIcon, bool disabledSleepIcon)
		{
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F4")]
		[Address(RVA = "0x35368C0", Offset = "0x3534EC0", VA = "0x1835368C0")]
		private void SetSleepIcon(bool value, GameObject iconGameObject, ref LinkUiElement linkUiElement)
		{
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F5")]
		[Address(RVA = "0x3536AE0", Offset = "0x35350E0", VA = "0x183536AE0")]
		private void RepositionIcon()
		{
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F6")]
		[Address(RVA = "0x3536EB0", Offset = "0x35354B0", VA = "0x183536EB0")]
		private void OnGrabEnter()
		{
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F7")]
		[Address(RVA = "0x3537040", Offset = "0x3535640", VA = "0x183537040")]
		private IEnumerator DelayedCollapse()
		{
			return null;
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F8")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SleepInteract()
		{
		}

		// Token: 0x04002F6E RID: 12142
		[Token(Token = "0x4002F6E")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("SleepIcon")]
		[SerializeField]
		private GameObject _sleepIcon;

		// Token: 0x04002F6F RID: 12143
		[Token(Token = "0x4002F6F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _disabledSleepIcon;

		// Token: 0x04002F70 RID: 12144
		[Token(Token = "0x4002F70")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GrabNode _grabNode;

		// Token: 0x04002F71 RID: 12145
		[Token(Token = "0x4002F71")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _minIconDistance;

		// Token: 0x04002F72 RID: 12146
		[Token(Token = "0x4002F72")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _maxIconDistance;

		// Token: 0x04002F73 RID: 12147
		[Token(Token = "0x4002F73")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _iconDistanceToPlayer;

		// Token: 0x04002F74 RID: 12148
		[Token(Token = "0x4002F74")]
		[FieldOffset(Offset = "0x44")]
		private bool _isWaitingToSleep;

		// Token: 0x04002F75 RID: 12149
		[Token(Token = "0x4002F75")]
		[FieldOffset(Offset = "0x48")]
		private LinkUiElement _enabledSleepLinkUiElement;

		// Token: 0x04002F76 RID: 12150
		[Token(Token = "0x4002F76")]
		[FieldOffset(Offset = "0x50")]
		private LinkUiElement _disabledSleepLinkUiElement;
	}
}
