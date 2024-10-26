--2605 - Executive Representatives
-- URL Task: https://judge.beecrowd.com/en/problems/view/2605
SELECT prod.name, prov.name 
FROM products prod
  INNER JOIN providers prov ON prod.id_providers = prov.id
  INNER JOIN categories cat ON cat.id = prod.id_categories 
WHERE prod.id_categories = 6
