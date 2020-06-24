<p style=";text-align:right;direction:rtl"> فيما يلي وصف وظيفي للقطع الرئيسية للبرنامج. </p>
<h2 style=";text-align:right;direction:rtl"> التسجيل الفردي </h2><ul style=";text-align:right;direction:rtl"><li style=";text-align:right;direction:rtl"> أثناء التسجيل ، يحدد المستخدمون موقع المنزل (المدينة ، المدينة ، القرية ، الرمز البريدي ، إلخ). </li><li style=";text-align:right;direction:rtl"> بناءً على موقعها ، يحدد النظام الكيانات الحاكمة التي تنتمي إليها. (البلد ، الولاية ، المقاطعة ، البلدة / المدينة ، إلخ) </li>
</ul><h2 style=";text-align:right;direction:rtl"> تسجيل الهيئات الحكومية </h2><ul style=";text-align:right;direction:rtl"><li style=";text-align:right;direction:rtl"> يمكن للمستخدم تسجيل أي من الكيانات الحاكمة التي ينتمي إليها. </li><li style=";text-align:right;direction:rtl"> ستشمل المعلومات المدخلة ما يلي: <ul style=";text-align:right;direction:rtl"><li style=";text-align:right;direction:rtl"> رابط الموقع </li><li style=";text-align:right;direction:rtl"> أسماء المسؤولين الحاكمين </li><li style=";text-align:right;direction:rtl"> عناوين URL حيث يمكن العثور على النصوص أو تسجيلات الاجتماعات </li>
</ul></li><li style=";text-align:right;direction:rtl"> سيرى المستخدمون الآخرون لهذا الموقع البيانات التي تم إدخالها بالفعل. يمكنهم التصويت على دقة أي عنصر بيانات وإدخال قيم بديلة. </li><li style=";text-align:right;direction:rtl"> سوف تتراكم الأصوات لكل قيمة بيانات. تصبح القيم التي حصلت على أكبر عدد من الأصوات هي القيم الرسمية. <a href="https://github.com/govmeeting/govmeeting/issues/62">جيث العدد 62</a> </li>
</ul><h2 style=";text-align:right;direction:rtl"> استيراد التسجيلات أو النصوص </h2><ul style=";text-align:right;direction:rtl"><li style=";text-align:right;direction:rtl"> سيقوم النظام بتنزيل التسجيلات أو النصوص الموجودة على الإنترنت وفقًا لجدول منتظم من المواقع المحددة في تسجيل الهيئات الحكومية. </li><li style=";text-align:right;direction:rtl"> يتوفر للمستخدمين أيضًا خيار تحميل التسجيلات أو النصوص. </li><li style=";text-align:right;direction:rtl"> لا تقدم العديد من الأماكن نصوصًا أو تسجيلات لاجتماعاتهم. ستوفر Govmeeting تطبيق Smartphome يمكن للمستخدمين استخدامه لتسجيل وتحميل تسجيل اجتماع شخصيًا. <a href="https://github.com/govmeeting/govmeeting/issues/18">جيث العدد رقم 18</a> </li>
</ul><h2 style=";text-align:right;direction:rtl"> النصوص الموجودة قبل المعالجة </h2><ul style=";text-align:right;direction:rtl"><li style=";text-align:right;direction:rtl"> تحويل النصوص إلى نص عادي. غالبًا ما تكون النصوص الموجودة في تنسيقات أخرى مثل PDF. يتم تحويلها إلى نص عادي بحيث تتم معالجتها بسهولة أكبر. </li><li style=";text-align:right;direction:rtl"> استخرج المعلومات مثل أسماء المتحدثين والمقاطع. </li>
</ul><h2 style=";text-align:right;direction:rtl"> نسخ التسجيلات باستخدام التعرف على الكلام </h2><ul style=";text-align:right;direction:rtl"><li style=";text-align:right;direction:rtl"> قم بتحويل التسجيلات إلى تنسيقات فيديو الويب الأساسية (mp4 و ogg و webm.) وهذا يجعل الوصول إليها أكثر سهولة على جميع أنواع الأجهزة. </li><li style=";text-align:right;direction:rtl"> استخراج ودمج المسارات الصوتية إذا كان أكثر من واحد. </li><li style=";text-align:right;direction:rtl"> حمّل الملف الصوتي إلى Google Cloud storage للاستعداد للنسخ. </li><li style=";text-align:right;direction:rtl"> اتصل بواجهة برمجة تطبيقات Google Speech غير المتزامنة لإجراء التعرف التلقائي على الصوت. </li><li style=";text-align:right;direction:rtl"> تنفيذ التعرف على تغيير مكبر الصوت. هناك Google API لهذا الغرض. </li><li style=";text-align:right;direction:rtl"> أضف تعريف المتحدث. سيستخدم هذا برنامج معالجة الكلام على الخادم. </li><li style=";text-align:right;direction:rtl"> ضع المعلومات في تنسيق JSON لمزيد من المعالجة. </li><li style=";text-align:right;direction:rtl"> قسّم ملفات الفيديو والصوت والنص إلى مقاطع عمل مدتها 3 دقائق ، بحيث يمكن للعديد من المتطوعين العمل في نفس الوقت على التدقيق اللغوي. </li>
</ul><h2 style=";text-align:right;direction:rtl"> تدقيق نص مكتوب [خطوة يدوية] </h2><ul style=";text-align:right;direction:rtl"><li style=";text-align:right;direction:rtl"> نص تدقيق الأخطاء. توفير واجهة سهلة الاستخدام لتصحيح الأخطاء بسرعة. </li><li style=";text-align:right;direction:rtl"> معلومات صحيحة مثل أسماء المتحدثين والمقاطع. </li>
</ul><p style=";text-align:right;direction:rtl"> محاولات Govmeeting لجعل المعالجة تلقائية قدر الإمكان. لكن أجهزة الكمبيوتر ليست ذكية كما نود. لا يزال البشر بحاجة إلى تصحيح أخطائهم. ولكن في كل يوم ، تصبح أجهزة الكمبيوتر أكثر ذكاءً ويجب أن يستمر هذا العمل في الحصول على أقل وأقل. </p>
<h2 style=";text-align:right;direction:rtl"> إضافة علامات مشكلة [خطوة يدوية] </h2><ul style=";text-align:right;direction:rtl"><li style=";text-align:right;direction:rtl"> تتمثل إحدى أهم الوظائف في إضافة علامات أو بيانات تعريف إلى النص بشكل صحيح. هذا ما يمكن: <ul style=";text-align:right;direction:rtl"><li style=";text-align:right;direction:rtl"> المعلومات التي يمكن تحديد موقعها بسهولة. </li><li style=";text-align:right;direction:rtl"> نسخة لفهرستها وتصفحها بسرعة </li><li style=";text-align:right;direction:rtl"> تنبيهات يتم تعيينها من قبل المستخدم حول قضايا محددة </li>
</ul></li><li style=";text-align:right;direction:rtl"> يجب تعيين أسماء المشكلات بواسطة الأشخاص وليس أجهزة الكمبيوتر. هذه هي أفضل طريقة للتأكد من أنها ذات مغزى. </li><li style=";text-align:right;direction:rtl"> من المهم توفير واجهة مستخدم سهلة الاستخدام وسريعة. </li>
</ul><p style=";text-align:right;direction:rtl"> في المستقبل ، ربما يمكن القيام بهذه الخطوة أيضًا في المقام الأول بواسطة الكمبيوتر. ولكن ليس كل شيء سيئ أن نحتاج إلى بعض العمل اليدوي من المتطوعين المجتمعيين. يساعد على توحيد الناس من أجل قضية مشتركة. إذا كانت هذه مدينة صغيرة 35000 ، فلا ينبغي أن يكون من الصعب تجنيد عشرات أو نحو ذلك لإعطاء فترة زمنية قصيرة كل شهر. </p>
<h2 style=";text-align:right;direction:rtl"> تعبئة قاعدة البيانات العلائقية </h2><p style=";text-align:right;direction:rtl"> يتم وضع البيانات في قاعدة بيانات علائقية بحيث يمكن الوصول إليها بسرعة باستخدام معايير متعددة. </p>
<h2 style=";text-align:right;direction:rtl"> البيانات متاحة الآن للاستخدام </h2><ul style=";text-align:right;direction:rtl"><li style=";text-align:right;direction:rtl"> يتوفر الآن نص مكتوب بقلم جاف ومتصفح </li><li style=";text-align:right;direction:rtl"> يتم إرسال ملخص للقضايا التي تمت مناقشتها في الاجتماع إلى طالبيها. </li><li style=";text-align:right;direction:rtl"> يتم إرسال التنبيهات حول قضايا محددة لمن يطلبها. </li>
</ul><h2 style=";text-align:right;direction:rtl"> يتم ترتيب الاجتماع الظاهري. </h2><ul style=";text-align:right;direction:rtl"><li style=";text-align:right;direction:rtl"> يتم إنشاء جدول الأعمال على أساس القضايا في الاجتماع الحقيقي. </li><li style=";text-align:right;direction:rtl"> يتم إرسال الدعوات لأفراد المجتمع. </li><li style=";text-align:right;direction:rtl"> تتضمن الدعوة طلبات للحصول على بنود إضافية ممكنة في جدول الأعمال. </li><li style=";text-align:right;direction:rtl"> عندما يتم تلقي الردود ، يتم إرسال الاقتراع لأولئك الذين سيحضرون. في هذا الاقتراع ، يمكن للأعضاء التصويت على أي بنود جديدة مقترحة لجدول الأعمال لإدراجها. </li><li style=";text-align:right;direction:rtl"> في غضون أيام قليلة ، يتم عقد اجتماع افتراضي. </li>
</ul><h2 style=";text-align:right;direction:rtl"> إدارة تتابع الأعمال </h2><p style=";text-align:right;direction:rtl"> يتم تنفيذ بعض خطوات سير العمل المذكورة أعلاه تلقائيًا بواسطة الكمبيوتر والبعض الآخر تتم يدويًا بواسطة المتطوعين. هناك أماكن في سير العمل حيث يجب على الشخص الحقيقي التحقق من أنه لا بأس من المتابعة: </p>
<ul style=";text-align:right;direction:rtl"><li style=";text-align:right;direction:rtl"> تحقق من صحة عناوين URL الخاصة باسترداد النصوص والتسجيلات. </li><li style=";text-align:right;direction:rtl"> تحقق من صحة محتوى الملفات المستردة. </li><li style=";text-align:right;direction:rtl"> تحقق من أن الإخراج من المعالجة المسبقة يبدو صالحًا. </li><li style=";text-align:right;direction:rtl"> تحقق من صحة تحويل الكلام إلى نص. </li><li style=";text-align:right;direction:rtl"> تحقق من أن تدقيق النص يبدو مكتملًا. </li><li style=";text-align:right;direction:rtl"> تحقق من اكتمال إضافة العلامات إلى النص المكتمل. </li><li style=";text-align:right;direction:rtl"> تحقق من أن بيانات النص النهائية تبدو كاملة وصالحة. </li>
</ul><p style=";text-align:right;direction:rtl"> يجب أن تكون هناك طريقة لرفع حقوق مستخدم أو أكثر من المستخدمين المسجلين في الموقع إلى منصب "مدير". </p>
<ul style=";text-align:right;direction:rtl"><li style=";text-align:right;direction:rtl"> سيتم إخطار المديرين كلما كان القرار معلقاً في سير العمل. </li><li style=";text-align:right;direction:rtl"> يمكن للمدير عندئذٍ تسجيل الدخول ومنح الموافقة على سير العمل للمتابعة أو رفضه. </li>
</ul>