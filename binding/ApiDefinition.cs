using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace MaterialControls
{
	// @interface AutoResizeTextView : UITextView
	[BaseType (typeof(UITextView))]
	interface AutoResizeTextView
	{
		// @property (copy, nonatomic) NSString * _Nullable placeholder;
		[NullAllowed, Export ("placeholder")]
		string Placeholder { get; set; }

		// @property (nonatomic) NSInteger minVisibleLines;
		[Export ("minVisibleLines")]
		nint MinVisibleLines { get; set; }

		// @property (nonatomic) NSInteger maxVisibleLines;
		[Export ("maxVisibleLines")]
		nint MaxVisibleLines { get; set; }

		// @property (nonatomic) float maxHeight;
		[Export ("maxHeight")]
		float MaxHeight { get; set; }

		// @property (nonatomic) UIColor * _Nullable placeholderColor;
		[NullAllowed, Export ("placeholderColor", ArgumentSemantic.Assign)]
		UIColor PlaceholderColor { get; set; }

		// @property (nonatomic, weak) MDTextField * _Nullable holder;
		[NullAllowed, Export ("holder", ArgumentSemantic.Weak)]
		MDTextField Holder { get; set; }
	}

	// @protocol MDButtonDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDButtonDelegate
	{
		// @optional -(void)rotationStarted:(id _Nonnull)sender;
		[Export ("rotationStarted:")]
		void RotationStarted (NSObject sender);

		// @optional -(void)rotationCompleted:(id _Nonnull)sender;
		[Export ("rotationCompleted:")]
		void RotationCompleted (NSObject sender);
	}

	// @interface MDButton : UIButton
	[BaseType (typeof(UIButton))]
	interface MDButton
	{
		// @property (nonatomic) UIColor * _Null_unspecified rippleColor;
		[Export ("rippleColor", ArgumentSemantic.Assign)]
		UIColor RippleColor { get; set; }

		// @property (nonatomic) NSInteger type;
		[Export ("type")]
		nint Type { get; set; }

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// @property (nonatomic) UIImage * _Nonnull imageNormal;
		[Export ("imageNormal", ArgumentSemantic.Assign)]
		UIImage ImageNormal { get; set; }

		// @property (nonatomic) UIImage * _Nonnull imageRotated;
		[Export ("imageRotated", ArgumentSemantic.Assign)]
		UIImage ImageRotated { get; set; }

		// @property (nonatomic) CGFloat imageSize;
		[Export ("imageSize")]
		nfloat ImageSize { get; set; }

		// @property (nonatomic) MDButtonType mdButtonType;
		[Export ("mdButtonType", ArgumentSemantic.Assign)]
		MDButtonType MdButtonType { get; set; }

		// @property (getter = isRotated, nonatomic) BOOL rotated;
		[Export ("rotated")]
		bool Rotated { [Bind ("isRotated")] get; set; }

		[Wrap ("WeakMdButtonDelegate")]
		[NullAllowed]
		MDButtonDelegate MdButtonDelegate { get; set; }

		// @property (nonatomic, weak) id<MDButtonDelegate> _Nullable mdButtonDelegate;
		[NullAllowed, Export ("mdButtonDelegate", ArgumentSemantic.Weak)]
		NSObject WeakMdButtonDelegate { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame type:(MDButtonType)buttonType rippleColor:(UIColor * _Nullable)rippleColor;
		[Export ("initWithFrame:type:rippleColor:")]
		IntPtr Constructor (CGRect frame, MDButtonType buttonType, [NullAllowed] UIColor rippleColor);
	}

	// @interface MDCollectionViewCell : UICollectionViewCell
	[BaseType (typeof(UICollectionViewCell))]
	interface MDCollectionViewCell
	{
		// @property (nonatomic) UIColor * rippleColor;
		[Export ("rippleColor", ArgumentSemantic.Assign)]
		UIColor RippleColor { get; set; }
	}

	// @interface MDProgress : UIView
	[BaseType (typeof(UIView))]
	interface MDProgress
	{
		// @property (nonatomic) UIColor * progressColor;
		[Export ("progressColor", ArgumentSemantic.Assign)]
		UIColor ProgressColor { get; set; }

		// @property (nonatomic) UIColor * trackColor;
		[Export ("trackColor", ArgumentSemantic.Assign)]
		UIColor TrackColor { get; set; }

		// @property (nonatomic) MDProgressType progressType;
		[Export ("progressType", ArgumentSemantic.Assign)]
		MDProgressType ProgressType { get; set; }

		// @property (nonatomic) MDProgressStyle progressStyle;
		[Export ("progressStyle", ArgumentSemantic.Assign)]
		MDProgressStyle ProgressStyle { get; set; }

		// @property (nonatomic) NSInteger type;
		[Export ("type")]
		nint Type { get; set; }

		// @property (nonatomic) NSInteger style;
		[Export ("style")]
		nint Style { get; set; }

		// @property (nonatomic) CGFloat trackWidth;
		[Export ("trackWidth")]
		nfloat TrackWidth { get; set; }

		// @property (nonatomic) CGFloat circularSize;
		[Export ("circularSize")]
		nfloat CircularSize { get; set; }

		// @property (nonatomic) CGFloat progress;
		[Export ("progress")]
		nfloat Progress { get; set; }

		// @property (nonatomic) BOOL enableTrackColor;
		[Export ("enableTrackColor")]
		bool EnableTrackColor { get; set; }
	}

	// @interface MDRippleLayer : CALayer
	[BaseType (typeof(CALayer))]
	interface MDRippleLayer
	{
		// @property (nonatomic) BOOL enableRipple;
		[Export ("enableRipple")]
		bool EnableRipple { get; set; }

		// @property (nonatomic) BOOL enableElevation;
		[Export ("enableElevation")]
		bool EnableElevation { get; set; }

		// @property (nonatomic) BOOL enableMask;
		[Export ("enableMask")]
		bool EnableMask { get; set; }

		// @property (nonatomic) CGFloat restingElevation;
		[Export ("restingElevation")]
		nfloat RestingElevation { get; set; }

		// @property (nonatomic) CGFloat rippleScaleRatio;
		[Export ("rippleScaleRatio")]
		nfloat RippleScaleRatio { get; set; }

		// @property (nonatomic) CGFloat effectSpeed;
		[Export ("effectSpeed")]
		nfloat EffectSpeed { get; set; }

		// @property (nonatomic) UIColor * _Null_unspecified effectColor;
		[Export ("effectColor", ArgumentSemantic.Assign)]
		UIColor EffectColor { get; set; }

		// -(instancetype _Nonnull)initWithSuperLayer:(CALayer * _Nonnull)superLayer;
		[Export ("initWithSuperLayer:")]
		IntPtr Constructor (CALayer superLayer);

		// -(instancetype _Nonnull)initWithSuperView:(UIView * _Nonnull)superView;
		[Export ("initWithSuperView:")]
		IntPtr Constructor (UIView superView);

		// -(void)setEffectColor:(UIColor * _Nonnull)color withRippleAlpha:(CGFloat)rippleAlpha backgroundAlpha:(CGFloat)backgroundAlpha;
		[Export ("setEffectColor:withRippleAlpha:backgroundAlpha:")]
		void SetEffectColor (UIColor color, nfloat rippleAlpha, nfloat backgroundAlpha);

		// -(void)startEffectsAtLocation:(CGPoint)touchLocation;
		[Export ("startEffectsAtLocation:")]
		void StartEffectsAtLocation (CGPoint touchLocation);

		// -(void)stopEffectsImmediately;
		[Export ("stopEffectsImmediately")]
		void StopEffectsImmediately ();

		// -(void)stopEffects;
		[Export ("stopEffects")]
		void StopEffects ();
	}

	// @protocol MDLayerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDLayerDelegate
	{
		// @optional -(void)mdLayer:(MDRippleLayer * _Nonnull)layer didFinishEffect:(CFTimeInterval)duration;
		[Export ("mdLayer:didFinishEffect:")]
		void DidFinishEffect (MDRippleLayer layer, double duration);
	}

	// @interface MDSlider : UIControl
	[BaseType (typeof(UIControl))]
	interface MDSlider
	{
		// @property (nonatomic) CGFloat value;
		[Export ("value")]
		float Value { get; set; }

		// @property (nonatomic) CGFloat maximumValue;
		[Export ("maximumValue")]
		float MaximumValue { get; set; }

		// @property (nonatomic) CGFloat minimumValue;
		[Export ("minimumValue")]
		float MinimumValue { get; set; }

		// @property (nonatomic) UIColor * _Nonnull thumbOnColor;
		[Export ("thumbOnColor", ArgumentSemantic.Assign)]
		UIColor ThumbOnColor { get; set; }

		// @property (nonatomic) UIColor * _Nonnull trackOnColor;
		[Export ("trackOnColor", ArgumentSemantic.Assign)]
		UIColor TrackOnColor { get; set; }

		// @property (nonatomic) UIColor * _Nonnull thumbOffColor;
		[Export ("thumbOffColor", ArgumentSemantic.Assign)]
		UIColor ThumbOffColor { get; set; }

		// @property (nonatomic) UIColor * _Nonnull trackOffColor;
		[Export ("trackOffColor", ArgumentSemantic.Assign)]
		UIColor TrackOffColor { get; set; }

		// @property (nonatomic) UIColor * _Nonnull disabledColor;
		[Export ("disabledColor", ArgumentSemantic.Assign)]
		UIColor DisabledColor { get; set; }

		// @property (nonatomic) UIColor * _Nullable tickMarksColor;
		[NullAllowed, Export ("tickMarksColor", ArgumentSemantic.Assign)]
		UIColor TickMarksColor { get; set; }

		// @property (nonatomic) UIImage * _Nullable leftImage;
		[NullAllowed, Export ("leftImage", ArgumentSemantic.Assign)]
		UIImage LeftImage { get; set; }

		// @property (nonatomic) UIImage * _Nullable rightImage;
		[NullAllowed, Export ("rightImage", ArgumentSemantic.Assign)]
		UIImage RightImage { get; set; }

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// @property (nonatomic) CGFloat step;
		[Export ("step")]
		nfloat Step { get; set; }

		// @property (nonatomic) BOOL enabledValueLabel;
		[Export ("enabledValueLabel")]
		bool EnabledValueLabel { get; set; }

		// @property (nonatomic) NSString * _Nullable valueFormatString;
		[NullAllowed, Export ("valueFormatString")]
		string ValueFormatString { get; set; }

		// @property (nonatomic) NSUInteger precision;
		[Export ("precision")]
		nuint Precision { get; set; }
	}

	// @protocol MDSnackbarDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDSnackbarDelegate
	{
		// @optional -(void)snackbarWillAppear:(MDSnackbar * _Nonnull)snackbar;
		[Export ("snackbarWillAppear:")]
		void SnackbarWillAppear (MDSnackbar snackbar);

		// @optional -(void)snackbarDidAppear:(MDSnackbar * _Nonnull)snackbar;
		[Export ("snackbarDidAppear:")]
		void SnackbarDidAppear (MDSnackbar snackbar);

		// @optional -(void)snackbarWillDisappear:(MDSnackbar * _Nonnull)snackbar;
		[Export ("snackbarWillDisappear:")]
		void SnackbarWillDisappear (MDSnackbar snackbar);

		// @optional -(void)snackbarDidDisappear:(MDSnackbar * _Nonnull)snackbar;
		[Export ("snackbarDidDisappear:")]
		void SnackbarDidDisappear (MDSnackbar snackbar);

		// @optional -(void)actionTouched:(MDSnackbar * _Nonnull)snackbar;
		[Export ("actionTouched:")]
		void ActionTouched (MDSnackbar snackbar);
	}

	// @interface MDSnackbar : UIControl
	[BaseType (typeof(UIControl))]
	interface MDSnackbar
	{
		// @property (nonatomic) NSString * _Nonnull text;
		[Export ("text")]
		string Text { get; set; }

		// @property (nonatomic) NSString * _Nonnull actionTitle;
		[Export ("actionTitle")]
		string ActionTitle { get; set; }

		// @property (nonatomic) UIColor * _Nonnull textColor;
		[Export ("textColor", ArgumentSemantic.Assign)]
		UIColor TextColor { get; set; }

		// @property (nonatomic) UIColor * _Nonnull actionTitleColor;
		[Export ("actionTitleColor", ArgumentSemantic.Assign)]
		UIColor ActionTitleColor { get; set; }

		// @property (nonatomic) double duration;
		[Export ("duration")]
		double Duration { get; set; }

		// @property (nonatomic) double bottomPadding;
		[Export ("bottomPadding")]
		double BottomPadding { get; set; }

		// @property (nonatomic) BOOL swipeable;
		[Export ("swipeable")]
		bool Swipeable { get; set; }

		// @property (nonatomic) BOOL multiline;
		[Export ("multiline")]
		bool Multiline { get; set; }

		// @property (readonly, nonatomic) BOOL isShowing;
		[Export ("isShowing")]
		bool IsShowing { get; }

		// -(instancetype _Nonnull)initWithText:(NSString * _Nonnull)text actionTitle:(NSString * _Nonnull)action;
		[Export ("initWithText:actionTitle:")]
		IntPtr Constructor (string text, string action);

		// -(instancetype _Nonnull)initWithText:(NSString * _Nonnull)text actionTitle:(NSString * _Nonnull)action duration:(double)duration;
		[Export ("initWithText:actionTitle:duration:")]
		IntPtr Constructor (string text, string action, double duration);

		// -(void)show;
		[Export ("show")]
		void Show ();

		// -(void)dismiss;
		[Export ("dismiss")]
		void Dismiss ();

		// -(void)addTarget:(id _Nonnull)target action:(SEL _Nonnull)aSelector;
		[Export ("addTarget:action:")]
		void AddTarget (NSObject target, Selector aSelector);

		// -(void)addDelegate:(id<MDSnackbarDelegate> _Nonnull)delegate;
		[Export ("addDelegate:")]
		void AddDelegate (MDSnackbarDelegate @delegate);

		// -(void)removeDelegate:(id<MDSnackbarDelegate> _Nonnull)delegate;
		[Export ("removeDelegate:")]
		void RemoveDelegate (MDSnackbarDelegate @delegate);
	}

	// @interface MDSwitch : UIControl
	[BaseType (typeof(UIControl))]
	interface MDSwitch
	{
		// @property (getter = isOn, nonatomic) BOOL on;
		[Export ("on")]
		bool On { [Bind ("isOn")] get; set; }

		// @property (nonatomic) UIColor * thumbOn;
		[Export ("thumbOn", ArgumentSemantic.Assign)]
		UIColor ThumbOn { get; set; }

		// @property (nonatomic) UIColor * trackOn;
		[Export ("trackOn", ArgumentSemantic.Assign)]
		UIColor TrackOn { get; set; }

		// @property (nonatomic) UIColor * thumbOff;
		[Export ("thumbOff", ArgumentSemantic.Assign)]
		UIColor ThumbOff { get; set; }

		// @property (nonatomic) UIColor * trackOff;
		[Export ("trackOff", ArgumentSemantic.Assign)]
		UIColor TrackOff { get; set; }

		// @property (nonatomic) UIColor * thumbDisabled;
		[Export ("thumbDisabled", ArgumentSemantic.Assign)]
		UIColor ThumbDisabled { get; set; }

		// @property (nonatomic) UIColor * trackDisabled;
		[Export ("trackDisabled", ArgumentSemantic.Assign)]
		UIColor TrackDisabled { get; set; }
	}

	// @protocol MDTabBarDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDTabBarDelegate
	{
		// @required -(void)tabBar:(MDTabBar * _Nonnull)tabBar didChangeSelectedIndex:(NSUInteger)selectedIndex;
		[Abstract]
		[Export ("tabBar:didChangeSelectedIndex:")]
		void DidChangeSelectedIndex (MDTabBar tabBar, nuint selectedIndex);
	}

	// @interface MDTabBar : UIView
	[BaseType (typeof(UIView))]
	interface MDTabBar
	{
		// @property (nonatomic) UIColor * _Null_unspecified textColor;
		[Export ("textColor", ArgumentSemantic.Assign)]
		UIColor TextColor { get; set; }

		// @property (nonatomic) UIColor * _Null_unspecified normalTextColor;
		[Export ("normalTextColor", ArgumentSemantic.Assign)]
		UIColor NormalTextColor { get; set; }

		// @property (nonatomic) UIColor * _Null_unspecified backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Assign)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic) UIColor * _Null_unspecified indicatorColor;
		[Export ("indicatorColor", ArgumentSemantic.Assign)]
		UIColor IndicatorColor { get; set; }

		// @property (nonatomic) UIColor * _Null_unspecified rippleColor;
		[Export ("rippleColor", ArgumentSemantic.Assign)]
		UIColor RippleColor { get; set; }

		// @property (nonatomic) UIFont * _Nullable textFont;
		[NullAllowed, Export ("textFont", ArgumentSemantic.Assign)]
		UIFont TextFont { get; set; }

		// @property (nonatomic) UIFont * _Nullable normalTextFont;
		[NullAllowed, Export ("normalTextFont", ArgumentSemantic.Assign)]
		UIFont NormalTextFont { get; set; }

		// @property (assign, nonatomic) CGFloat horizontalInset;
		[Export ("horizontalInset")]
		nfloat HorizontalInset { get; set; }

		// @property (assign, nonatomic) CGFloat horizontalPaddingPerItem;
		[Export ("horizontalPaddingPerItem")]
		nfloat HorizontalPaddingPerItem { get; set; }

		// @property (nonatomic) NSUInteger selectedIndex;
		[Export ("selectedIndex")]
		nuint SelectedIndex { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MDTabBarDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MDTabBarDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic) NSInteger numberOfItems;
		[Export ("numberOfItems")]
		nint NumberOfItems { get; }

		// -(void)setItems:(NSArray<id> * _Nonnull)items;
		[Export ("setItems:")]
		void SetItems (NSObject[] items);

		// -(void)insertItem:(id _Nonnull)item atIndex:(NSUInteger)index animated:(BOOL)animated;
		[Export ("insertItem:atIndex:animated:")]
		void InsertItem (NSObject item, nuint index, bool animated);

		// -(void)removeItemAtIndex:(NSUInteger)index animated:(BOOL)animated;
		[Export ("removeItemAtIndex:animated:")]
		void RemoveItemAtIndex (nuint index, bool animated);

		// -(void)replaceItem:(id _Nonnull)item atIndex:(NSUInteger)index;
		[Export ("replaceItem:atIndex:")]
		void ReplaceItem (NSObject item, nuint index);

		// -(NSArray<UIView *> * _Nonnull)tabs;
		[Export ("tabs")]
		//[Verify (MethodToProperty)]
		UIView[] Tabs { get; }

		// -(void)moveIndicatorToFrame:(CGRect)frame withAnimated:(BOOL)animated;
		[Export ("moveIndicatorToFrame:withAnimated:")]
		void MoveIndicatorToFrame (CGRect frame, bool animated);
	}

	// @protocol MDTabBarViewControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDTabBarViewControllerDelegate
	{
		// @required -(UIViewController * _Nonnull)tabBarViewController:(MDTabBarViewController * _Nonnull)viewController viewControllerAtIndex:(NSUInteger)index;
		[Abstract]
		[Export ("tabBarViewController:viewControllerAtIndex:")]
		UIViewController ViewControllerAtIndex (MDTabBarViewController viewController, nuint index);
	}

	// @interface MDTabBarViewController : UIViewController
	[BaseType (typeof(UIViewController))]
	interface MDTabBarViewController
	{
		// @property (readonly, nonatomic) MDTabBar * _Nonnull tabBar;
		[Export ("tabBar")]
		MDTabBar TabBar { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MDTabBarViewControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MDTabBarViewControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic) NSUInteger selectedIndex;
		[Export ("selectedIndex")]
		nuint SelectedIndex { get; set; }

		// -(instancetype _Nonnull)initWithDelegate:(id<MDTabBarViewControllerDelegate> _Nonnull)delegate;
		[Export ("initWithDelegate:")]
		IntPtr Constructor (MDTabBarViewControllerDelegate @delegate);

		// -(void)setItems:(NSArray<id> * _Nonnull)items;
		[Export ("setItems:")]
		void SetItems (NSObject[] items);
	}

	// @interface MDTableViewCell : UITableViewCell
	[BaseType (typeof(UITableViewCell))]
	interface MDTableViewCell
	{
		// @property (nonatomic) UIColor * rippleColor;
		[Export ("rippleColor", ArgumentSemantic.Assign)]
		UIColor RippleColor { get; set; }
	}

	// @protocol MDTextFieldDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDTextFieldDelegate
	{
		// @optional -(void)textFieldDidChange:(MDTextField * _Nonnull)textField;
		[Export ("textFieldDidChange:")]
		void TextFieldDidChange (MDTextField textField);

		// @optional -(BOOL)textFieldShouldBeginEditing:(MDTextField * _Nonnull)textField;
		[Export ("textFieldShouldBeginEditing:")]
		bool TextFieldShouldBeginEditing (MDTextField textField);

		// @optional -(void)textFieldDidBeginEditing:(MDTextField * _Nonnull)textField;
		[Export ("textFieldDidBeginEditing:")]
		void TextFieldDidBeginEditing (MDTextField textField);

		// @optional -(BOOL)textFieldShouldEndEditing:(MDTextField * _Nonnull)textField;
		[Export ("textFieldShouldEndEditing:")]
		bool TextFieldShouldEndEditing (MDTextField textField);

		// @optional -(void)textFieldDidEndEditing:(MDTextField * _Nonnull)textField;
		[Export ("textFieldDidEndEditing:")]
		void TextFieldDidEndEditing (MDTextField textField);

		// @optional -(BOOL)textField:(MDTextField * _Nonnull)textField shouldChangeCharactersInRange:(NSRange)range replacementString:(NSString * _Nonnull)string;
		[Export ("textField:shouldChangeCharactersInRange:replacementString:")]
		bool TextField (MDTextField textField, NSRange range, string @string);

		// @optional -(BOOL)textFieldShouldReturn:(MDTextField * _Nonnull)textField;
		[Export ("textFieldShouldReturn:")]
		bool TextFieldShouldReturn (MDTextField textField);
	}

	// @interface MDTextField : UIControl
	[BaseType (typeof(UIControl))]
	interface MDTextField
	{
		// @property (nonatomic) NSString * _Null_unspecified hint;
		[Export ("hint")]
		string Hint { get; set; }

		// @property (nonatomic) NSString * _Null_unspecified label;
		[Export ("label")]
		string Label { get; set; }

		// @property (nonatomic) BOOL floatingLabel;
		[Export ("floatingLabel")]
		bool FloatingLabel { get; set; }

		// @property (nonatomic) BOOL highlightLabel;
		[Export ("highlightLabel")]
		bool HighlightLabel { get; set; }

		// @property (nonatomic) NSString * _Null_unspecified errorMessage;
		[Export ("errorMessage")]
		string ErrorMessage { get; set; }

		// @property (nonatomic) NSInteger maxCharacterCount;
		[Export ("maxCharacterCount")]
		nint MaxCharacterCount { get; set; }

		// @property (nonatomic) UIColor * _Null_unspecified normalColor;
		[Export ("normalColor", ArgumentSemantic.Assign)]
		UIColor NormalColor { get; set; }

		// @property (nonatomic) UIColor * _Null_unspecified highlightColor;
		[Export ("highlightColor", ArgumentSemantic.Assign)]
		UIColor HighlightColor { get; set; }

		// @property (nonatomic) UIColor * _Null_unspecified errorColor;
		[Export ("errorColor", ArgumentSemantic.Assign)]
		UIColor ErrorColor { get; set; }

		// @property (nonatomic) UIColor * _Null_unspecified disabledColor;
		[Export ("disabledColor", ArgumentSemantic.Assign)]
		UIColor DisabledColor { get; set; }

		// @property (nonatomic) UIColor * _Null_unspecified textColor;
		[Export ("textColor", ArgumentSemantic.Assign)]
		UIColor TextColor { get; set; }

		// @property (nonatomic) UIColor * _Null_unspecified hintColor;
		[Export ("hintColor", ArgumentSemantic.Assign)]
		UIColor HintColor { get; set; }

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// @property (nonatomic) BOOL autoComplete;
		[Export ("autoComplete")]
		bool AutoComplete { get; set; }

		// @property (nonatomic) BOOL singleLine;
		[Export ("singleLine")]
		bool SingleLine { get; set; }

		// @property (nonatomic) BOOL fullWidth;
		[Export ("fullWidth")]
		bool FullWidth { get; set; }

		// @property (nonatomic) NSInteger minVisibleLines;
		[Export ("minVisibleLines")]
		nint MinVisibleLines { get; set; }

		// @property (nonatomic) NSInteger maxVisibleLines;
		[Export ("maxVisibleLines")]
		nint MaxVisibleLines { get; set; }

		// @property (nonatomic) NSString * _Null_unspecified text;
		[Export ("text")]
		string Text { get; set; }

		// @property (nonatomic) BOOL secureTextEntry;
		[Export ("secureTextEntry")]
		bool SecureTextEntry { get; set; }

		// @property (nonatomic) BOOL dividerAnimation;
		[Export ("dividerAnimation")]
		bool DividerAnimation { get; set; }

		// @property (nonatomic) BOOL restrictInBounds;
		[Export ("restrictInBounds")]
		bool RestrictInBounds { get; set; }

		// @property (nonatomic) UIReturnKeyType returnKeyType;
		[Export ("returnKeyType", ArgumentSemantic.Assign)]
		UIReturnKeyType ReturnKeyType { get; set; }

		// @property (nonatomic) UIKeyboardType keyboardType;
		[Export ("keyboardType", ArgumentSemantic.Assign)]
		UIKeyboardType KeyboardType { get; set; }

		// @property (nonatomic) BOOL hasError;
		[Export ("hasError")]
		bool HasError { get; set; }

		// @property (nonatomic) UIFont * _Nonnull labelsFont;
		[Export ("labelsFont", ArgumentSemantic.Assign)]
		UIFont LabelsFont { get; set; }

		// @property (nonatomic) UIFont * _Nonnull inputTextFont;
		[Export ("inputTextFont", ArgumentSemantic.Assign)]
		UIFont InputTextFont { get; set; }

		// @property (nonatomic) NSLayoutConstraint * _Nonnull textViewHeightConstraint;
		[Export ("textViewHeightConstraint", ArgumentSemantic.Assign)]
		NSLayoutConstraint TextViewHeightConstraint { get; set; }

		// @property (nonatomic) NSArray<NSString *> * _Nullable suggestionsDictionary;
		[NullAllowed, Export ("suggestionsDictionary", ArgumentSemantic.Assign)]
		string[] SuggestionsDictionary { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MDTextFieldDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MDTextFieldDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readwrite, nonatomic, strong) UIView * _Nullable inputAccessoryView;
		[NullAllowed, Export ("inputAccessoryView", ArgumentSemantic.Strong)]
		UIView InputAccessoryView { get; set; }

		// -(float)requiredHeightWithNumberOfTextLines:(NSUInteger)numberOfLines;
		[Export ("requiredHeightWithNumberOfTextLines:")]
		float RequiredHeightWithNumberOfTextLines (nuint numberOfLines);
	}

	// TODO: Convert the below properties to get/set methods as these are extension methods
	// @interface MDExtension (UIView)
//	[Category]
//	[BaseType (typeof(UIView))]
//	interface MDExtension
//	{
//		// @property (nonatomic) CGFloat mdWidth;
//		[Export ("mdWidth")]
//		nfloat MdWidth { get; set; }
//
//		// @property (nonatomic) CGFloat mdHeight;
//		[Export ("mdHeight")]
//		nfloat MdHeight { get; set; }
//
//		// @property (nonatomic) CGFloat mdTop;
//		[Export ("mdTop")]
//		nfloat MdTop { get; set; }
//
//		// @property (nonatomic) CGFloat mdLeft;
//		[Export ("mdLeft")]
//		nfloat MdLeft { get; set; }
//
//		// @property (nonatomic) CGFloat mdBottom;
//		[Export ("mdBottom")]
//		nfloat MdBottom { get; set; }
//
//		// @property (nonatomic) CGFloat mdRight;
//		[Export ("mdRight")]
//		nfloat MdRight { get; set; }
//
//		// @property (nonatomic) CGFloat mdCenterX;
//		[Export ("mdCenterX")]
//		nfloat MdCenterX { get; set; }
//
//		// @property (nonatomic) CGFloat mdCenterY;
//		[Export ("mdCenterY")]
//		nfloat MdCenterY { get; set; }
//	}

	// @interface MDToast : UIControl
	[BaseType (typeof(UIControl))]
	interface MDToast
	{
		// @property (nonatomic) NSString * _Nullable text;
		[NullAllowed, Export ("text")]
		string Text { get; set; }

		// @property (nonatomic) UIColor * _Nullable textColor;
		[NullAllowed, Export ("textColor", ArgumentSemantic.Assign)]
		UIColor TextColor { get; set; }

		// @property (nonatomic) UIFont * _Nullable textFont;
		[NullAllowed, Export ("textFont", ArgumentSemantic.Assign)]
		UIFont TextFont { get; set; }

		// @property (nonatomic) NSTimeInterval duration;
		[Export ("duration")]
		double Duration { get; set; }

		// @property (readonly, nonatomic) BOOL isShowing;
		[Export ("isShowing")]
		bool IsShowing { get; }

		// @property (nonatomic) MDGravity gravity;
		[Export ("gravity", ArgumentSemantic.Assign)]
		MDGravity Gravity { get; set; }

		// -(instancetype _Nonnull)initWithText:(NSString * _Nonnull)text duration:(NSTimeInterval)duration;
		[Export ("initWithText:duration:")]
		IntPtr Constructor (string text, double duration);

		// -(void)setGravity:(MDGravity)gravity xOffset:(int)xOffset yOffset:(int)yOffset;
		[Export ("setGravity:xOffset:yOffset:")]
		void SetGravity (MDGravity gravity, int xOffset, int yOffset);

		// -(void)show;
		[Export ("show")]
		void Show ();

		// -(void)dismiss;
		[Export ("dismiss")]
		void Dismiss ();
	}

	// @protocol MDTouchGestureRecognizerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDTouchGestureRecognizerDelegate
	{
		// @optional -(void)touchesBegan:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesBegan:withEvent:")]
		void TouchesBegan (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// @optional -(void)touchesMoved:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesMoved:withEvent:")]
		void TouchesMoved (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// @optional -(void)touchesCancelled:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesCancelled:withEvent:")]
		void TouchesCancelled (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// @optional -(void)touchesEnded:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesEnded:withEvent:")]
		void TouchesEnded (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);
	}

	// @interface MDTouchGestureRecognizer : UIGestureRecognizer
	[BaseType (typeof(UIGestureRecognizer))]
	interface MDTouchGestureRecognizer
	{
		[Wrap ("WeakTouchDelegate")]
		[NullAllowed]
		MDTouchGestureRecognizerDelegate TouchDelegate { get; set; }

		// @property (nonatomic, weak) id<MDTouchGestureRecognizerDelegate> _Nullable touchDelegate;
		[NullAllowed, Export ("touchDelegate", ArgumentSemantic.Weak)]
		NSObject WeakTouchDelegate { get; set; }
	}
}
